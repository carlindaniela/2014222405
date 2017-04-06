using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222405
{
    class Asiento
    {
        public string NumSerie { get; set; }
        public Cinturon Cinturon;


        public Asiento() { }

        public Asiento(string _NumSerie, Cinturon _Cinturon) {

            NumSerie = _NumSerie;
            Cinturon = _Cinturon;
        
        }
        
    }
}
