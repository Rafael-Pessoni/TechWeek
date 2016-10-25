using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Model
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = Messages.Required, AllowEmptyStrings = false)]
        [MaxLength(200, ErrorMessage = Messages.MaxLength)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = Messages.Required, AllowEmptyStrings = false)]
        [Display(Name = "Cadastro")]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = Messages.Required, AllowEmptyStrings = false)]
        [Display(Name = "Termino Planejado")]
        public DateTime DataTerminoPlanejado { get; set; }

        [Display(Name = "Termino Efetivo")]
        public DateTime? DataTerminoEfetivo { get; set; }

        public virtual ICollection<Interessado> Interessados { get; set; }

        public void AddInteressado(Interessado interessado)
        {
            if(Interessados == null)
                Interessados = new List<Interessado>();

            Interessados.Add(interessado);
        }
    }
}
