using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GalloTube.Models;

[Table("Tag")]
public class Tag
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Display(Name = "Nome")]
    [Required(ErrorMessage = "O Nome é obrigatório")]
    [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 100 caracteres")]
    public string Name { get; set; }


    public ICollection<VideoTag> Video { get; set; }
}
