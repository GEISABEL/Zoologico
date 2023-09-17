using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    public class Veterinario {
        public string Nome { get; set; }
        public int Id_veterinatio { get; set; }
        public int Telefone { get; set; }
        public void Examinar (Animal animal)
        {
            Console.WriteLine("Examinando o {0}", animal.Nome);
            animal.EmitirSom();
            Console.WriteLine("Exame Finalizado!");
        }
        public void Examinar (List<Animal> animals){
            foreach (Animal animal in animals){
                Examinar (animal);
            }
            
        }
    }
}
