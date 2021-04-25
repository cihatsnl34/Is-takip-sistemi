using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP_PROJE
{
    class Oyuncu:Personel
    {
        public string rol { get; set; }
        public Müsteri proje { get; set; }

        public Oyuncu()
        {
            this.proje = new Müsteri();
        }
    }
}
