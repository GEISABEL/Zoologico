using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.PortableExecutable;
using System.Net;

namespace zoologico
{
    public class DALZoologico
    {
        //encontrar onde está o arquivo do banco de dados
        public static string path = Directory.GetCurrentDirectory() + "\\zoologico.db";
        // "C:\Users\jeffe\source\repos\zoologico\bin\Debug\net6.0\zoologico.db"

        //criar uma propriedade do tipo sqliteconnection
        private static SQLiteConnection sqliteConnection;

        //método que realiza a conexão
        private static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection("Data Source=" + path);
            sqliteConnection.Open();
            return sqliteConnection;
        }

        public static DataTable GetVeterinariosDataTable()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM veterinarios";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex);
                throw;
            }
        }

        public static List<Veterinario> GetVeterinariosList()
        {
            List<Veterinario> veterinarios = new List<Veterinario>();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM veterinarios";
                    using (var reader = cmd.ExecuteReader())
                    {
                        //Console.WriteLine("### LISTA DE VETERINÁRIOS ###");
                        //Console.WriteLine("{0, -5} | {1}", "ID", "Nome");
                        //Console.WriteLine(new string('-', 25));

                        while (reader.Read())
                        {
                            Veterinario veterinario = new Veterinario(Convert.ToInt32(reader["id"]), reader["nome"].ToString());
                            veterinarios.Add(veterinario);

                            //Console.WriteLine("{0, -5} | {1}", veterinario.Id, veterinario.Nome);
                        }
                        //Console.WriteLine("");
                    }
                }
                return veterinarios;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro SQL: " + ex);
                throw;
            }
        }

        public static void InserirVeterinario()
        {

            try
            {

                //ler as informações do teclado da veterinario que o usuário quer inserir
                Console.WriteLine("Digite o id do veterinario que vai ser inserida: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o nome do veterinario que vai ser inserida: ");
                string nome = Console.ReadLine();

                //conexão com o banco de dados 
                using (var cmd = DbConnection().CreateCommand())
                {
                    //criar a query (consulta) sql
                    cmd.CommandText = "INSERT INTO veterinarios (id, nome) VALUES (@id, @nome)";
                    //definir os valores que vão ser substituídos pelos parâmetros
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    //executar a query sql
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        public static void DeletarVeterinario()
        {

            try
            {

                //ler as informações do teclado da veterinario que o usuário quer deletar
                Console.WriteLine("Digite o id do veterinario que vai ser deletada: ");
                int id = int.Parse(Console.ReadLine());

                //conexão com o banco de dados 
                using (var cmd = DbConnection().CreateCommand())
                {
                    //criar a query (consulta) sql
                    cmd.CommandText = "DELETE FROM veterinarios WHERE id = @id";
                    //definir os valores que vão ser substituídos pelos parâmetros
                    cmd.Parameters.AddWithValue("@id", id);
                    //executar a query sql
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        public static void AtualizarNomeVeterinario()
        {

            try
            {

                //ler as informações do teclado da veterinario que o usuário quer atualizar
                Console.WriteLine("Digite o id do veterinario que vai ter o seu nome atualizado: ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o novo nome do veterinario: ");
                string novoNome = Console.ReadLine();

                //conexão com o banco de dados 
                using (var cmd = DbConnection().CreateCommand())
                {
                    //criar a query (consulta) sql
                    cmd.CommandText = "UPDATE veterinarios SET nome = @nome WHERE id = @id";
                    //definir os valores que vão ser substituídos pelos parâmetros
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nome", novoNome);
                    //executar a query sql
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        public static void GetVeterinariosComParametro()
        {
            try
            {
                // Ler as informações do teclado do veterinário que o usuário quer consultar
                Console.WriteLine("Digite o id do veterinário que você quer saber o nome: ");
                int id = int.Parse(Console.ReadLine());

                // Conexão com o banco de dados 
                using (var cmd = DbConnection().CreateCommand())
                {
                    // Criar a query (consulta) sql
                    cmd.CommandText = "SELECT * FROM veterinarios WHERE id = @id";

                    // Definir os valores que vão ser substituídos pelos parâmetros
                    cmd.Parameters.AddWithValue("@id", id);

                    // Executar a query sql
                    using (var reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("### DETALHES DO VETERINÁRIO ###");
                        Console.WriteLine("{0, -5} | {1}", "ID", "Nome");
                        Console.WriteLine(new string('-', 25));

                        while (reader.Read())
                        {
                            Console.WriteLine("{0, -5} | {1}", reader["id"], reader["nome"]);
                        }
                        Console.WriteLine("");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }


        //////////////////////////VISITANTES\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        public static DataTable GetVisitantesDataTable()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM visitantes";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex);
                throw;
            }
        }

        public static List<Visitante> GetVisitantesList()
        {
            List<Visitante> visitantes = new List<Visitante>();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM visitantes";
                    using (var reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("### LISTA DE VISITANTES ###");
                        Console.WriteLine("{0, -5} | {1}", "ID", "Nome");
                        Console.WriteLine(new string('-', 25));

                        while (reader.Read())
                        {
                            Visitante visitante = new Visitante(Convert.ToInt32(reader["id"]), reader["nome"].ToString());
                            visitantes.Add(visitante);

                            Console.WriteLine("{0, -5} | {1}", visitante.Id, visitante.Nome);
                        }
                        Console.WriteLine("");
                    }
                }
                return visitantes;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro SQL: " + ex);
                throw;
            }
        }

        public static void InserirVisitante()
        {

            try
            {

                //ler as informações do teclado da visitante que o usuário quer inserir
                Console.WriteLine("Digite o id do visitante que vai ser inserida: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o nome do visitante que vai ser inserida: ");
                string nome = Console.ReadLine();

                //conexão com o banco de dados 
                using (var cmd = DbConnection().CreateCommand())
                {
                    //criar a query (consulta) sql
                    cmd.CommandText = "INSERT INTO visitantes (id, nome) VALUES (@id, @nome)";
                    //definir os valores que vão ser substituídos pelos parâmetros
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    //executar a query sql
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        public static void DeletarVisitante()
        {

            try
            {

                //ler as informações do teclado da visitante que o usuário quer deletar
                Console.WriteLine("Digite o id do visitante que vai ser deletada: ");
                int id = int.Parse(Console.ReadLine());

                //conexão com o banco de dados 
                using (var cmd = DbConnection().CreateCommand())
                {
                    //criar a query (consulta) sql
                    cmd.CommandText = "DELETE FROM visitantes WHERE id = @id";
                    //definir os valores que vão ser substituídos pelos parâmetros
                    cmd.Parameters.AddWithValue("@id", id);
                    //executar a query sql
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        public static void AtualizarNomeVisitante()
        {

            try
            {

                //ler as informações do teclado da visitante que o usuário quer atualizar
                Console.WriteLine("Digite o id do visitante que vai ter o seu nome atualizado: ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o novo nome do visitante: ");
                string novoNome = Console.ReadLine();

                //conexão com o banco de dados 
                using (var cmd = DbConnection().CreateCommand())
                {
                    //criar a query (consulta) sql
                    cmd.CommandText = "UPDATE visitantes SET nome = @nome WHERE id = @id";
                    //definir os valores que vão ser substituídos pelos parâmetros
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nome", novoNome);
                    //executar a query sql
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        public static void GetVisitantesComParametro()
        {
            try
            {
                // Ler as informações do teclado do visitante que o usuário quer consultar
                Console.WriteLine("Digite o id do visitante que você quer saber o nome: ");
                int id = int.Parse(Console.ReadLine());

                // Conexão com o banco de dados 
                using (var cmd = DbConnection().CreateCommand())
                {
                    // Criar a query (consulta) sql
                    cmd.CommandText = "SELECT * FROM visitantes WHERE id = @id";

                    // Definir os valores que vão ser substituídos pelos parâmetros
                    cmd.Parameters.AddWithValue("@id", id);

                    // Executar a query sql
                    using (var reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("### DETALHES DO VISITANTE ###");
                        Console.WriteLine("{0, -5} | {1}", "ID", "Nome");
                        Console.WriteLine(new string('-', 25));

                        while (reader.Read())
                        {
                            Console.WriteLine("{0, -5} | {1}", reader["id"], reader["nome"]);
                        }
                        Console.WriteLine("");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        ///////////////////////////////////////ADMINISTRADORES\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        public static DataTable GetAdministradoresDataTable()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM administradores";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex);
                throw;
            }
        }

        public static List<Administrador> GetAdministradoresList()
        {
            List<Administrador> administradores = new List<Administrador>();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM administradores";
                    using (var reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("### LISTA DE ADMINISTRADORES ###");
                        Console.WriteLine("{0, -5} | {1}", "ID", "Nome");
                        Console.WriteLine(new string('-', 25));

                        while (reader.Read())
                        {
                            Administrador administrador = new Administrador(Convert.ToInt32(reader["id"]), reader["nome"].ToString());
                            administradores.Add(administrador);

                            Console.WriteLine("{0, -5} | {1}", administrador.Id, administrador.Nome);
                        }
                        Console.WriteLine("");
                    }
                }
                return administradores;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro SQL: " + ex);
                throw;
            }
        }

        public static void InserirAdministrador()
        {

            try
            {

                //ler as informações do teclado da administrador que o usuário quer inserir
                Console.WriteLine("Digite o id do administrador que vai ser inserida: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o nome do administrador que vai ser inserida: ");
                string nome = Console.ReadLine();

                //conexão com o banco de dados 
                using (var cmd = DbConnection().CreateCommand())
                {
                    //criar a query (consulta) sql
                    cmd.CommandText = "INSERT INTO administradores (id, nome) VALUES (@id, @nome)";
                    //definir os valores que vão ser substituídos pelos parâmetros
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    //executar a query sql
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        public static void DeletarAdministrador()
        {

            try
            {

                //ler as informações do teclado da administrador que o usuário quer deletar
                Console.WriteLine("Digite o id do administrador que vai ser deletada: ");
                int id = int.Parse(Console.ReadLine());

                //conexão com o banco de dados 
                using (var cmd = DbConnection().CreateCommand())
                {
                    //criar a query (consulta) sql
                    cmd.CommandText = "DELETE FROM administradores WHERE id = @id";
                    //definir os valores que vão ser substituídos pelos parâmetros
                    cmd.Parameters.AddWithValue("@id", id);
                    //executar a query sql
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        public static void AtualizarNomeAdministrador()
        {

            try
            {

                //ler as informações do teclado da administrador que o usuário quer atualizar
                Console.WriteLine("Digite o id do administrador que vai ter o seu nome atualizado: ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o novo nome do administrador: ");
                string novoNome = Console.ReadLine();

                //conexão com o banco de dados 
                using (var cmd = DbConnection().CreateCommand())
                {
                    //criar a query (consulta) sql
                    cmd.CommandText = "UPDATE administradores SET nome = @nome WHERE id = @id";
                    //definir os valores que vão ser substituídos pelos parâmetros
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nome", novoNome);
                    //executar a query sql
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        public static void GetAdministradoresComParametro()
        {
            try
            {
                // Ler as informações do teclado do administrador que o usuário quer consultar
                Console.WriteLine("Digite o id do administrador que você quer saber o nome: ");
                int id = int.Parse(Console.ReadLine());

                // Conexão com o banco de dados 
                using (var cmd = DbConnection().CreateCommand())
                {
                    // Criar a query (consulta) sql
                    cmd.CommandText = "SELECT * FROM administradores WHERE id = @id";

                    // Definir os valores que vão ser substituídos pelos parâmetros
                    cmd.Parameters.AddWithValue("@id", id);

                    // Executar a query sql
                    using (var reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("### DETALHES DO ADMINISTRADOR ###");
                        Console.WriteLine("{0, -5} | {1}", "ID", "Nome");
                        Console.WriteLine(new string('-', 25));

                        while (reader.Read())
                        {
                            Console.WriteLine("{0, -5} | {1}", reader["id"], reader["nome"]);
                        }
                        Console.WriteLine("");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        /////////////////////////////////////// ANIMAIS \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        public static DataTable GetAnimaisDataTable()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM animais";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex);
                throw;
            }
        }

        public static List<Animal> GetAnimaisList()
        {
            List<Animal> animais = new List<Animal>();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM animais";
                    using (var reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("### LISTA DE ANIMAIS ###");
                        Console.WriteLine("{0, -5} | {1, -15} | {2}", "ID", "Nome", "Espécie");
                        Console.WriteLine(new string('-', 35));

                        while (reader.Read())
                        {
                            Animal animal = new Animal(Convert.ToInt32(reader["id"]), reader["nome"].ToString(), reader["especie"].ToString());
                            animais.Add(animal);

                            Console.WriteLine("{0, -5} | {1, -15} | {2}", animal.Id, animal.Nome, animal.Especie);
                        }
                        Console.WriteLine("");
                    }
                }
                return animais;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro SQL: " + ex);
                throw;
            }
        }

        public static void InserirAnimal()
        {

            try
            {

                //ler as informações do teclado da animal que o usuário quer inserir
                Console.WriteLine("Digite o id do animal que vai ser inserida: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o nome do animal que vai ser inserida: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite a especie do animal que vai ser inserida: ");
                string especie = Console.ReadLine();

                //conexão com o banco de dados 
                using (var cmd = DbConnection().CreateCommand())
                {
                    // Criar a query (consulta) sql
                    cmd.CommandText = "INSERT INTO animais (id, nome, especie) VALUES (?, ?, ?)";

                    // Definir os valores que vão ser substituídos pelos parâmetros
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("nome", nome);
                    cmd.Parameters.AddWithValue("especie", especie);

                    // Executar a query sql
                    cmd.ExecuteNonQuery();
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        public static void DeletarAnimal()
        {

            try
            {

                //ler as informações do teclado da animal que o usuário quer deletar
                Console.WriteLine("Digite o id do animal que vai ser deletada: ");
                int id = int.Parse(Console.ReadLine());

                //conexão com o banco de dados 
                using (var cmd = DbConnection().CreateCommand())
                {
                    //criar a query (consulta) sql
                    cmd.CommandText = "DELETE FROM animais WHERE id = @id";
                    //definir os valores que vão ser substituídos pelos parâmetros
                    cmd.Parameters.AddWithValue("@id", id);
                    //executar a query sql
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        public static void AtualizarNomeAnimal()
        {

            try
            {

                //ler as informações do teclado da animal que o usuário quer atualizar
                Console.WriteLine("Digite o id do animal que vai ter o seu nome atualizado: ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o novo nome do animal: ");
                string novoNome = Console.ReadLine();

                Console.WriteLine("Digite a especie do animal: ");
                string novaEspecie = Console.ReadLine();


                //conexão com o banco de dados 
                using (var cmd = DbConnection().CreateCommand())
                {
                    // Criar a query (consulta) sql
                    cmd.CommandText = "UPDATE animais SET nome = ?, especie = ? WHERE id = ?";

                    // Definir os valores que vão ser substituídos pelos parâmetros
                    cmd.Parameters.AddWithValue("nome", novoNome);
                    cmd.Parameters.AddWithValue("especie", novaEspecie);
                    cmd.Parameters.AddWithValue("id", id);

                    // Executar a query sql
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        public static void GetAnimaisComParametro()
        {
            try
            {
                // Ler as informações do teclado do animal que o usuário quer consultar
                Console.WriteLine("Digite o id do animal que você quer saber o nome: ");
                int id = int.Parse(Console.ReadLine());

                // Conexão com o banco de dados 
                using (var cmd = DbConnection().CreateCommand())
                {
                    // Criar a query (consulta) sql
                    cmd.CommandText = "SELECT * FROM animais WHERE id = @id";

                    // Definir os valores que vão ser substituídos pelos parâmetros
                    cmd.Parameters.AddWithValue("@id", id);

                    // Executar a query sql
                    using (var reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("### DETALHES DO ANIMAL ###");
                        Console.WriteLine("{0, -5} | {1, -15} | {2}", "ID", "Nome", "Espécie");
                        Console.WriteLine(new string('-', 35));

                        while (reader.Read())
                        {
                            Console.WriteLine("{0, -5} | {1, -15} | {2}", reader["id"], reader["nome"], reader["especie"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }


    }
}
