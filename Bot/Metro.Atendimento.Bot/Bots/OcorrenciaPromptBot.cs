using Metro.Atendimento.Bot.Models;
using Microsoft.Bot.Builder;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace Metro.Atendimento.Bot.Bots
{
    public class OcorrenciaPromptBot : ActivityHandler
    {
        private readonly BotState _userState;
        private readonly BotState _conversationState;
        public OcorrenciaPromptBot(ConversationState conversationState, UserState userState)
        {
            _conversationState = conversationState;
            _userState = userState;
        }


        protected override async Task OnMessageActivityAsync(ITurnContext<Microsoft.Bot.Schema.IMessageActivity> turnContext, CancellationToken cancellationToken)
        {

            var conversationStateAccessors = _conversationState.CreateProperty<ConversationFlow>(nameof(ConversationFlow));
            var flow = await conversationStateAccessors.GetAsync(turnContext, () => new ConversationFlow(), cancellationToken);

            var userStateAccessors = _userState.CreateProperty<OcorrenciaRequest>(nameof(OcorrenciaRequest));
            var ocorrencia = await userStateAccessors.GetAsync(turnContext, () => new OcorrenciaRequest(), cancellationToken);

            await FillOutUserProfileAsync(flow, ocorrencia, turnContext, cancellationToken);

            // Save changes.
            await _conversationState.SaveChangesAsync(turnContext, false, cancellationToken);
            await _userState.SaveChangesAsync(turnContext, false, cancellationToken);
        }

        private static async Task FillOutUserProfileAsync(ConversationFlow flow, OcorrenciaRequest ocorrencia, ITurnContext turnContext, CancellationToken cancellationToken)
        {
            var input = turnContext.Activity.Text?.Trim();
            string message;

            switch (flow.LastQuestionAsked)
            {
                case ConversationFlow.Question.None:
                    await turnContext.SendActivityAsync("Deseja abrir um chamado?", null, null, cancellationToken);
                    flow.LastQuestionAsked = ConversationFlow.Question.Pergunta;
                    break;

                case ConversationFlow.Question.Pergunta:

                    if (input.ToLower() == "sim")
                    {
                        await turnContext.SendActivityAsync("Qual assunto?", null, null, cancellationToken);
                        flow.LastQuestionAsked = ConversationFlow.Question.Assunto;
                    }
                    else
                    {
                        flow.LastQuestionAsked = ConversationFlow.Question.None;
                    }

                    break;


                case ConversationFlow.Question.Assunto:

                    ocorrencia.Assunto = input;

                    await turnContext.SendActivityAsync("Digite o seu problema ou dúvida", null, null, cancellationToken);
                    flow.LastQuestionAsked = ConversationFlow.Question.Descricao;

                    break;

                case ConversationFlow.Question.Descricao:

                    ocorrencia.Mensagem = input;

                    var protocolo = AbrirChamado(ocorrencia); 

                    await turnContext.SendActivityAsync("Anote o número do seu protocolo: " + protocolo, null, null, cancellationToken);
                    flow.LastQuestionAsked = ConversationFlow.Question.None;

                    break;

            }
        }


        public static string AbrirChamado(OcorrenciaRequest ocorrencia)
        {
            Services.Ocorrencia ocorrenciaServices = new Services.Ocorrencia();
            var response = ocorrenciaServices.CriarOcorrencia(ocorrencia);

            return response.NumeroProtocolo.ToString();
        }

        protected override async Task OnMembersAddedAsync(IList<Microsoft.Bot.Schema.ChannelAccount> membersAdded, ITurnContext<Microsoft.Bot.Schema.IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            var welcomeText = "Olá, em que posso ajudar?";

            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    await turnContext.SendActivityAsync(MessageFactory.Text(welcomeText, welcomeText), cancellationToken);
                }
            }
        }
    }
}
