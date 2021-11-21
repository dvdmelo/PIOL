using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro.Atendimento.Bot
{
    public class ConversationFlow
    {
        public enum Question
        {
            Assunto,
            Descricao,
            Pergunta,
            None
        }

        public Question LastQuestionAsked { get; set; } = Question.None;
    }
}
