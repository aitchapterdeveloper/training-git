using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTrainingDemo.Object
{
    public class TiketReguler : Ticket
    {
        public override int HitungHarga()
        {
            return 50000;
        }

        public TiketReguler (string namaFilm)
        {
            NamaFilm = namaFilm;
        }
    }
}
