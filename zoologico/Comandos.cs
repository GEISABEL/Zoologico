using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace zoologico
{
    public class Comandos
    {
        //public string Ativa { get; set; }
        public static void InserirVet()
        {
            try
            {
                Console.WriteLine(" ");
                Console.WriteLine("### ESTADO DO BD APÓS INSERÇÃO ###");
                List<Veterinario> veterinarios2 = DALZoologico.GetVeterinariosList();

                // Exibir o cabeçalho da tabela
                Console.WriteLine("{0,-10} {1}", "ID", "Nome");
                Console.WriteLine(new string('-', 22));

                foreach (Veterinario veterinario in veterinarios2)
                {
                    // Exibir os dados formatados na tabela
                    Console.WriteLine("{0,-10} {1}", veterinario.Id, veterinario.Nome);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }


        public static void DeletarVet()
        {
            try
            {
                Console.WriteLine(" ");
                Console.WriteLine("### ESTADO DO BD APÓS DELEÇÃO ###");

                List<Veterinario> veterinarios3 = DALZoologico.GetVeterinariosList();

                // Exibir o cabeçalho da tabela
                Console.WriteLine("{0,-10} {1}", "ID", "Nome");
                Console.WriteLine(new string('-', 22));

                foreach (Veterinario veterinario in veterinarios3)
                {
                    // Exibir os dados formatados na tabela
                    //Console.WriteLine("{0,-10} {1}", veterinario.Id, veterinario.Nome);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }


        public static void AtualizarVet()
        {
            try
            {
                Console.WriteLine(" ");
                Console.WriteLine("### ESTADO DO BD APÓS ATUALIZAÇÃO ###");

                List<Veterinario> veterinarios4 = DALZoologico.GetVeterinariosList();

                // Exibir o cabeçalho da tabela
                Console.WriteLine("{0,-10} {1}", "ID", "Nome");
                Console.WriteLine(new string('-', 22));

                foreach (Veterinario veterinario in veterinarios4)
                {
                    // Exibir os dados formatados na tabela
                    //Console.WriteLine("{0,-10} {1}", veterinario.Id, veterinario.Nome);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }


        public static void ConsultarVet()
        {
            try
            {
                Console.WriteLine("### DETALHES DO VETERINARIO2 ###");
                List<Veterinario> veterinarios = DALZoologico.GetVeterinariosList();

                // Exibir o cabeçalho da tabela
                Console.WriteLine("{0, -5} | {1}", "ID", "Nome2");
                Console.WriteLine(new string('-', 25));

                foreach (Veterinario veterinario in veterinarios)
                {
                    // Exibir os dados formatados na tabela
                    Console.WriteLine("{0,-10} {1}", veterinario.Id, veterinario.Nome);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        //////////////////////////// VISITANTES \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        public static void InserirVis()
        {
            try
            {
                Console.WriteLine(" ");
                Console.WriteLine("### ESTADO DO BD APÓS INSERÇÃO ###");
                List<Visitante> visitantes2 = DALZoologico.GetVisitantesList();

                // Exibir o cabeçalho da tabela
                Console.WriteLine("{0,-10} {1}", "ID", "Nome");
                Console.WriteLine(new string('-', 22));

                foreach (Visitante visitante in visitantes2)
                {
                    // Exibir os dados formatados na tabela
                    Console.WriteLine("{0,-10} {1}", visitante.Id, visitante.Nome);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }


        public static void DeletarVis()
        {
            try
            {
                Console.WriteLine(" ");
                Console.WriteLine("### ESTADO DO BD APÓS DELEÇÃO ###");

                List<Visitante> visitantes3 = DALZoologico.GetVisitantesList();

                Console.WriteLine("{0,-10} {1}", "ID", "Nome");
                Console.WriteLine(new string('-', 22));

                foreach (Visitante visitante in visitantes3)
                {
                    Console.WriteLine("{0,-10} {1}", visitante.Id, visitante.Nome);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }


        public static void AtualizarVis()
        {
            try
            {
                Console.WriteLine(" ");
                Console.WriteLine("### ESTADO DO BD APÓS ATUALIZAÇÃO ###");

                List<Visitante> visitantes4 = DALZoologico.GetVisitantesList();

                Console.WriteLine("{0,-10} {1}", "ID", "Nome");
                Console.WriteLine(new string('-', 22));

                foreach (Visitante visitante in visitantes4)
                {
                    Console.WriteLine("{0,-10} {1}", visitante.Id, visitante.Nome);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }


        public static void ConsultarVis()
        {
            try
            {
                Console.WriteLine("### DETALHES DO VISITANTE ###");

                List<Visitante> visitantes = DALZoologico.GetVisitantesList();

                Console.WriteLine("{0,-10} {1}", "ID", "Nome");
                Console.WriteLine(new string('-', 22));

                foreach (Visitante visitante in visitantes)
                {
                    Console.WriteLine("{0,-10} {1}", visitante.Id, visitante.Nome);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        /////////////////////////// ADMINISTRADORES \\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        public static void InserirAdm()
        {
            try
            {
                Console.WriteLine(" ");
                Console.WriteLine("### ESTADO DO BD APÓS INSERÇÃO ###");

                List<Administrador> administradores2 = DALZoologico.GetAdministradoresList();

                Console.WriteLine("{0,-10} {1}", "ID", "Nome");
                Console.WriteLine(new string('-', 22));

                foreach (Administrador administrador in administradores2)
                {
                    Console.WriteLine("{0,-10} {1}", administrador.Id, administrador.Nome);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }


        public static void DeletarAdm()
        {
            try
            {
                Console.WriteLine(" ");
                Console.WriteLine("### ESTADO DO BD APÓS DELEÇÃO ###");

                List<Administrador> administradores3 = DALZoologico.GetAdministradoresList();

                Console.WriteLine("{0,-10} {1}", "ID", "Nome");
                Console.WriteLine(new string('-', 22));

                foreach (Administrador administrador in administradores3)
                {
                    Console.WriteLine("{0,-10} {1}", administrador.Id, administrador.Nome);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }


        public static void AtualizarAdm()
        {
            try
            {
                Console.WriteLine(" ");
                Console.WriteLine("### ESTADO DO BD APÓS ATUALIZAÇÃO ###");

                List<Administrador> administradores4 = DALZoologico.GetAdministradoresList();

                Console.WriteLine("{0,-10} {1}", "ID", "Nome");
                Console.WriteLine(new string('-', 22));

                foreach (Administrador administrador in administradores4)
                {
                    Console.WriteLine("{0,-10} {1}", administrador.Id, administrador.Nome);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }


        public static void ConsultarAdm()
        {
            try
            {
                Console.WriteLine("### DETALHES DO ADMINISTRADOR(A) ###");
                List<Administrador> administradores = DALZoologico.GetAdministradoresList();

                Console.WriteLine("{0,-10} {1}", "ID", "Nome");
                Console.WriteLine(new string('-', 22));

                foreach (Administrador administrador in administradores)
                {
                    Console.WriteLine("{0,-10} {1}", administrador.Id, administrador.Nome);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        ////////////////////////// COMANDOS ANIMAIS \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        public static void Inserir_Animal()
        {
            try
            {
                Console.WriteLine(" ");
                Console.WriteLine("### ESTADO DO BD APÓS INSERÇÃO ###");
                List<Animal> animais2 = DALZoologico.GetAnimaisList();

                Console.WriteLine("{0,-10} {1,-15} {2}", "ID", "Nome", "Espécie");
                Console.WriteLine(new string('-', 35));

                foreach (Animal animal in animais2)
                {
                    Console.WriteLine("{0,-10} {1,-15} {2}", animal.Id, animal.Nome, animal.Especie);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }


        public static void Deletar_Animal()
        {
            try
            {
                Console.WriteLine(" ");
                Console.WriteLine("### ESTADO DO BD APÓS DELEÇÃO ###");

                List<Animal> animais3 = DALZoologico.GetAnimaisList();

                Console.WriteLine("{0,-10} {1,-15} {2}", "ID", "Nome", "Espécie");
                Console.WriteLine(new string('-', 35));

                foreach (Animal animal in animais3)
                {
                    Console.WriteLine("{0,-10} {1,-15} {2}", animal.Id, animal.Nome, animal.Especie);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        public static void Atualizar_Animal()
        {
            try
            {
                Console.WriteLine(" ");
                Console.WriteLine("### ESTADO DO BD APÓS ATUALIZAÇÃO ###");

                List<Animal> animais4 = DALZoologico.GetAnimaisList();

                Console.WriteLine("{0,-10} {1,-15} {2}", "ID", "Nome", "Espécie");
                Console.WriteLine(new string('-', 35));

                foreach (Animal animal in animais4)
                {
                    Console.WriteLine("{0,-10} {1,-15} {2}", animal.Id, animal.Nome, animal.Especie);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        public static void Consultar_Animal()
        {
            try
            {
                Console.WriteLine("### DETALHES DO ANIMAL ###");
                List<Animal> animais = DALZoologico.GetAnimaisList();

                Console.WriteLine("{0,-10} {1,-15} {2}", "ID", "Nome", "Espécie");
                Console.WriteLine(new string('-', 35));

                foreach (Animal animal in animais)
                {
                    Console.WriteLine("{0,-10} {1,-15} {2}", animal.Id, animal.Nome, animal.Especie);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }
}
