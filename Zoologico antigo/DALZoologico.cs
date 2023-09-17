using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlClient;

namespace Zoologico
{
    public class DALZoologico
    {

        public static string path = Directory.GetCurrentDirectory() + "E:\\Usuarios\\Documentos\\GitHub\\Zoologico\\db\\zoologico.sql";

        public static SQLiteConnection SQLiteConnection;
        public static SQLiteConnection DbConnection()
        {

            SQLiteConnection = new SQLiteConnection("Data Source=" + path);
            SQLiteConnection.Open();
            return SQLiteConnection;
        }

        public static DataTable GetVisitantes()
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
                Console.WriteLine("Erro: " + ex.Message);
                throw;
            }
            
        }
        public static List<Visitantes> GetVisitantesList()
        {
            List<Visitantes> visitante = new List<Visitantes>();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM visitantes";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Visitantes visitantes = new Visitantes(Convert.ToInt32(reader["id_visitante"]), reader["nome"].ToString());
                            visitante.Add(visitantes);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: ", ex.Message);
                throw;
            }
        }
        public static void InserirVisitante()
        {
            try
            {
                Console.WriteLine("Digite o id do Visitante:");
                Console.WriteLine();
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o nome do Visitante");
                Console.WriteLine();
                string nome = Console.ReadLine();
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO visitantes (id_visitantes, nome) VALUES (@id, @nome)";
                    // Adicionar parâmetros personalizados
                    cmd.Parameters.AddWithValue("@id", id_visitante);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.ExecuteNonQuery(); //Executando a Query SQL
                }
                Console.WriteLine("Dados Inseridos com sucesso!");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro ao inserir o novo visitante: " + ex.Message);
                throw;
            }
        }

    }
}

