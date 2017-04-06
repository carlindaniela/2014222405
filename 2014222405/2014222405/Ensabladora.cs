using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222405
{
    class Ensabladora
    {
        List<Carro> carro;
        
        public Ensabladora() { }

        public Ensabladora() {

            
            carro= new  List<Carro> ();
        
        }

        public void agregar(Carro _carro)
        {
            carro.Add(_carro) ;
        }


        public void eliminar(Carro _carro)
        {
            carro.Remove(_carro);
        }

        public void IniciarPersonalizacion(string Numchasis)
        {
            Carro numchasis = carro.Find(t => t.NumSerieChasis == Numchasis);
            
            Console.WriteLine("Personalizacion Iniciada [{0}]", Numchasis);
        }
         public void FilnalizarPersonalizacion( string Numchasis)
        {
            Carro numchasis = carro.Find(t => t.NumSerieChasis == Numchasis);
            Console.WriteLine("Personalizacion Finalizada [{0}]", Numchasis);
        }

        public void EnsamblarCarro(TipoCarro tipocarro, TipoAuto tipoauto, TipoBus tipobus)
         {

         }

    }
}
