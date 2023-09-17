using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace zoologico
{
    public class Administrador
    {
        //métodos de encapsulamento
        public int Id { get; set; }
        public string Nome { get; set; }
        
        //construtor explícito
        public Administrador(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

    }
}
