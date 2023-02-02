using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data
{
    [Table("StudentiPredmeti")]
    public class StudentiPredmetiIB180161
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public virtual PredmetiIB180161 Predmet { get; set; }
        public int Ocjena { get; set; }
        public DateTime Datum { get; set; }
    }
}
