using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuberBreakfast.Entities;

public class Breakfast
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

    [Column("id")]
    public long Id { get; set; }

    [Column("uuid")]
    public Guid Uuid { get; set; }

    [Required]
    [Column("name")]
    public string Name { get; set; } = string.Empty;

    [Column("description")]
    public string Description { get; set; } = string.Empty;

    [Column("startdatetime")]
    public DateTime StartDateTime { get; set; }

    [Column("enddatetime")]
    public DateTime EndDateTime { get; set; }

}