using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artha.Shared.Entities
{
    public class Country : EclipseLayer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CountryID { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        [ConcurrencyCheck]
        public string Code { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        public Country()
        {
            this.CountryID = 0;
            this.Code = "";
            this.Name = "";
        }
    }
}
