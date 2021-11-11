using System.ComponentModel.DataAnnotations;

namespace Metro.Atendimento.Portal.ViewModels
{
    public class CreateAtendimentoViewModel
    {
        [Required]
        public string Assunto { get; set; }
        
        [Required]
        public string Mensagem { get; set; }
    }
}
