using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data
{
    [Table("StudentiSeminarski")]
    public class StudentSeminarskiIB180161
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public virtual PredmetIB180161 Predmet { get; set; }
        public byte[] Slika { get; set; }
        public string Opis { get; set; }
        public DateTime Datum { get; set; }
    }
}
