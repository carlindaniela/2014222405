using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222405
{
    public abstract class Carro
    {
        public string NumSerieMotor { get; set; }
        public string NumSerieChasis { get; set; }
        public Asiento Asiento;
        public Llanta Llanta;
        public Parabrisas Parabrisas;
        public volante Volante;
        public Propietario Propietario;

        public Carro() {}
        public Carro(string _NumSerieMotor, string _NumSerieChasis, Asiento _Asiento, Llanta _Llanta, Parabrisas _Parabrisas, volante _Volante, Propietario _Propietario)
        {
            NumSerieMotor = _NumSerieMotor;
            NumSerieChasis = _NumSerieChasis;
            Asiento = _Asiento;
            Llanta = _Llanta;
            Parabrisas = _Parabrisas;
            Volante = _Volante;
            Propietario = _Propietario;
        }





    }
}
