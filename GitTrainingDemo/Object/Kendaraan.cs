using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTrainingDemo.Object
{
    public class Kendaraan
    {
        public string PlatNomor;
        public virtual int HitungBiayaParkir(int jam)
        {
            return jam * 3000;
        }
    }
}
