using System.ComponentModel.DataAnnotations;

namespace Metro.Atendimento.Portal.ViewModels
{
    public class CreateAtendimentoViewModel
    {
        [Required]
        public string Titulo { get; set; }
        
        [Required]
        public string Descricao { get; set; }
    }
}
