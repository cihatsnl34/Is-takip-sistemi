using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP_PROJE
{
    class TeknikEkip: Personel
    {
        public Müsteri proje { get; set; }

        public TeknikEkip()
        {
            this.proje = new Müsteri();
        }
    }
}
