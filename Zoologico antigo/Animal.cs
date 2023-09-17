using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    public abstract class Animal {

        public string Nome { get; set; }
        public string Sexo { get; set; }
        public int Id_animal { get; set; }
        public float Peso { get; set; }
    public abstract void EmitirSom ();
    }
}