using System.ComponentModel.DataAnnotations;

namespace ToDoList.Model
{
    public class Interessado
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = Messages.Required, AllowEmptyStrings = false)]
        [MaxLength(200, ErrorMessage = Messages.MaxLength)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = Messages.Required, AllowEmptyStrings = false)]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        public int TarefaId { get; set; }
    }
}
