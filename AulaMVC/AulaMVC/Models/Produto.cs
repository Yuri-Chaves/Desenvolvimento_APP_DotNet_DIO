using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AulaMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage ="Campo Obrigatório")]
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        [Display(Name = "Id da Categoria")]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
