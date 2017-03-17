using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class EntidadBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}
