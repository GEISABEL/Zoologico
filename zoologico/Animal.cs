using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace zoologico
{
    public class Animal
    {
        //métodos de encapsulamento
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Especie { get; set; }

        //construtor explícito
        public Animal(int id, string nome, string especie)
        {
            Id = id;
            Nome = nome;
            Especie = especie;
        }

    }
}
