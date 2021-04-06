using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.ViewModels
{
    public class ProdutoViewModel
    {
        
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome é requerido.")]
        public string Name { get; set; }

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "O sobrenome é requerido.")]
        public double Valor { get; set; }       

        [Display(Name = "Ativo")]
        public bool Ative { get; set; }
    }
}
