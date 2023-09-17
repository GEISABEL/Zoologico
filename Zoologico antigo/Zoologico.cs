using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    public class Zoologico {
        public string RazaoSocial { get; set; }
        public string Localizacao { get; set; }
        public int Id_Zoologico { get; set; }
        public List < Animal > Animais { get; set; } = new List< Animal >();
    }
}
