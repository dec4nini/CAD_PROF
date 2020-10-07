using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CAD_Prof.Models
{
    public class ProfessorModel
    {
        [Key]
        [Display(Name ="ID")]
        public int Id { get; set; }
        [Display(Name = "Nome: ")]
        [Required(ErrorMessage ="Este campo é obrigatório!")]
        public String Nome { get; set; }
        [Display(Name = "Endereço:")]
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public String Endereco { get; set; }
        [Display(Name = "Telefone:")]
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public String Telefone { get; set; }
        [Display(Name = "Email:")]
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public String Email { get; set; }
        [Display(Name = "Disciplina:")]
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public String Disciplina { get; set; }


    }
}