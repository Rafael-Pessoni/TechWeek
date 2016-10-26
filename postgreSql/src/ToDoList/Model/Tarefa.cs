using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Model
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório", AllowEmptyStrings = false)]
        [MaxLength(200, ErrorMessage = "O campo {0} está limitado a {1} caracteres")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório", AllowEmptyStrings = false)]
        [MaxLength(100, ErrorMessage = "O campo {0} está limitado a {1} caracteres")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [MaxLength(100, ErrorMessage = "O campo {0} está limitado a {1} caracteres")]
        [EmailAddress(ErrorMessage = "O e-mail fornecido não é válido")]
        [Required(ErrorMessage = "O campo {0} é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "O campo {0} é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Termino Planejado")]
        public DateTime DataTerminoPlanejado { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Termino Efetivo")]
        public DateTime? DataTerminoEfetivo { get; set; }
    }
}
