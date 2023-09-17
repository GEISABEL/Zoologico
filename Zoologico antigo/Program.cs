using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Elefante elefante = new Elefante();
            elefante.Nome = "Elele";
            elefante.EmitirSom();

            Preguica preguica = new Preguica();
            preguica.Nome = "Pepe";
            preguica.EmitirSom();

            Zoologico zoologico = new Zoologico();
            zoologico.RazaoSocial = "Morais&SilvaLTDA";
            zoologico.Animais.Add(preguica);
            zoologico.Animais.Add(elefante);

            Veterinario veterinario = new Veterinario();
            veterinario.Nome = "Lucas";
            veterinario.Examinar(zoologico.Animais);
            try
            {
                DataTable dt = new DataTable();
                dt = DALZoologico.GetVisitantes();
                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColmn col in dt.Columns)
                    {
                        Console.WriteLine(col.ColumnName + ":" + row[col]);
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                throw;
            }
            List<Visitantes> visitantes = DALZoologico.GetVisitantesList();
            foreach (Visitantes visitante in visitantes)
            {
                Console.WriteLine("Id: {0}", visitante.Id_Visitante);
                Console.WriteLine("Nome: {0}", visitante.Nome);
                Console.WriteLine();
            }
        }
    }
}









