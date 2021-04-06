using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.ViewModels
{
    public class ProdutoViewModel
    {

        [Key]
        [Display(Name = "Código")]
        [Required(ErrorMessage = "O código é requerido.")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome é requerido.")]
        public string Name { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "O preço é requerido.")]
        public string Preco { get; set; }

        [Display(Name = "Ativo")]
        public bool Ative { get; set; }
    }
}
