using System.ComponentModel.DataAnnotations;

namespace APIAtendimento.ViewModels
{
    public class CreateAtendimentoViewModel
    {
        [Required]
        public string Titulo { get; set; }
        
        [Required]
        public string Descricao { get; set; }
    }
}
