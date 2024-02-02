using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Movimiento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string concepto { get; set; }
        public Decimal valor {  get; set; } 
        public int idCaja {  get; set; }

        
        [ForeignKey("idCaja")]
        public virtual Caja Caja { get; set; }
    }
}
