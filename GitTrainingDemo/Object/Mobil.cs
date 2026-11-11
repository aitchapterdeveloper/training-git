using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTrainingDemo.Object
{
    public class Mobil : Kendaraan
    {
        public override int HitungBiayaParkir(int jam)
        {
            return jam * 5000;
        }
    }
}
