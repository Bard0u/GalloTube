using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GalloTube.Models;

public class Video
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Display(Name = "Nome")]
    [Required(ErrorMessage = "O Nome é obrigatório")]
    [StringLength(100, ErrorMessage = "O Nome deve possuir no máximo 100 caracteres")]
    public string Name { get; set; }

    [Display(Name = "Descrição")]
    [Required(ErrorMessage = "A Descrição é obrigatória")]
    [StringLength(8000, ErrorMessage = "A Descrição deve possuir no máximo 5000 caracteres")]
    public string Description { get; set; }

    [Column(TypeName = "Lançamento")]
    [Display(Name = "data de lançamento")]
    [Required(ErrorMessage = "A data de lançamento é obrigatória")]
    public DateTime UploadDate { get; set; }

    [Display(Name = "Duração (em minutos)")]
    [Required(ErrorMessage = "A Duração é obrigatória")]
    public Int16 Duration { get; set; }

    [StringLength(200)]
    [Display(Name = "Thumbnail")]
    public string Thumbnail { get; set; }

    [StringLength(200)]
    [Display(Name = "Arquivo do Video")]
    public string VideoFile { get; set; }



    public ICollection<VideoTag> Tag { get; set; }
}
