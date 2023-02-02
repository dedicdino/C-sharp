using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data
{
    [Table("StudentiKonsultacije")]
    public class StudentiKonsultacijeIB180161
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public virtual PredmetiIB180161 Predmet { get; set; }
        public DateTime VrijemeOdrzavanja { get; set; }
        public string Napomena { get; set; }
    }
}
