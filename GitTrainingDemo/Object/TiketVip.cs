using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTrainingDemo.Object
{
    public class TiketVip : Ticket
    {
        public override int HitungHarga()
        {
            return 100000;
        }

        public TiketVip(string namaFilm)
        {
            NamaFilm = namaFilm;
        }
    }
}
