using System;
using System.Data;
using zoologico;

namespace zoologico
{
    class Program
    {

        static void Main(string[] args)
        {

            try
            {
                DataTable dt = new DataTable();
                dt = DALZoologico.GetVeterinariosDataTable();

 //               foreach (DataRow row in dt.Rows)
 //               {
 //                   foreach (DataColumn col in dt.Columns)
 //                   {
 //                       Console.WriteLine(col.ColumnName + ": " + row[col]);
 //                   }
 //                   Console.WriteLine();
 //               }
 //
            }
            catch (Exception ex) {
                Console.WriteLine("Erro: " + ex.Message);
            }
            ///////////////////////////////////////////////////////////////////////////////

            try
            {
                // Criando uma instância de Comandos
                Comandos comandos = new Comandos();
            
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }

            ///////////////////////////////// [MENU PRINCIPAL] \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            int escolhainicial = -1;

            while (escolhainicial != 0)
            {
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("1 - Veterinários");
                Console.WriteLine("2 - Animais");
                Console.WriteLine("3 - Visitantes");
                Console.WriteLine("4 - Administradores");
                Console.WriteLine("0 - Sair");

                escolhainicial = Convert.ToInt32(Console.ReadLine());

                switch (escolhainicial)
                {
                    case 1:
                        ///////////////////////////////// MENU VETERINARIO \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
                        int escolha = -1;

                        while (escolha != 0)
                        {
                            Console.WriteLine("Escolha uma operação:");
                            Console.WriteLine("5 - Inserir Veterinário");
                            Console.WriteLine("6 - Deletar Veterinário");
                            Console.WriteLine("7 - Atualizar Nome do Veterinário");
                            Console.WriteLine("8 - Consultar Nome do Veterinário");
                            Console.WriteLine("0 - Voltar");

                            escolha = Convert.ToInt32(Console.ReadLine());

                            switch (escolha)
                            {
                                case 5:
                                    //inserção de dados
                                    DALZoologico.InserirVeterinario();
                                    Comandos.InserirVet();

                                    break;
                                case 6:
                                    //deleção de dados
                                    DALZoologico.DeletarVeterinario();
                                    //Comandos.DeletarVet();

                                    break;
                                case 7:
                                    //atualização de dados
                                    DALZoologico.AtualizarNomeVeterinario();
                                    //Comandos.AtualizarVet();

                                    break;
                                case 8:
                                    // consulta dos dados parametrizada
                                    DALZoologico.GetVeterinariosComParametro();
                                    //Comandos.ConsultarVet();

                                    break;
                                case 0:
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida. Tente novamente.");
                                    break;
                            }
                        }
                        //////////////////////////////FIM MENU VETERINARIO\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
                        break;

                    case 2:
                        ///////////////////////////////// MENU ANIMAL \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
                        int escolha1 = -1;

                        while (escolha1 != 0)
                        {
                            Console.WriteLine("Escolha uma operação:");
                            Console.WriteLine("9 - Inserir Animal");
                            Console.WriteLine("10 - Deletar Animal");
                            Console.WriteLine("11 - Atualizar Nome do Animal");
                            Console.WriteLine("12 - Consultar Nome do Animal");
                            Console.WriteLine("0 - Voltar");

                            escolha1 = Convert.ToInt32(Console.ReadLine());

                            switch (escolha1)
                            {
                                case 9:
                                    //inserção de dados
                                    DALZoologico.InserirAnimal();
                                    //Comandos.InserirVet();

                                    break;
                                case 10:
                                    //deleção de dados
                                    DALZoologico.DeletarAnimal();
                                    //Comandos.DeletarVet();

                                    break;
                                case 11:
                                    //atualização de dados
                                    DALZoologico.AtualizarNomeAnimal();
                                    //Comandos.AtualizarVet();

                                    break;
                                case 12:
                                    // consulta dos dados parametrizada
                                    DALZoologico.GetAnimaisComParametro();
                                    //Comandos.ConsultarVet();

                                    break;
                                case 0:
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida. Tente novamente.");
                                    break;
                            }
                        }
                        break;
                    //////////////////////////////FIM MENU ANIMAL\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
                    case 3:
                        //////////////////////////////MENU VISITANTE\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
                        int escolha2 = -1;

                        while (escolha2 != 0)
                        {
                            Console.WriteLine("Escolha uma operação:");
                            Console.WriteLine("13 - Inserir Visitante");
                            Console.WriteLine("14 - Deletar Visitante");
                            Console.WriteLine("15 - Atualizar Nome do Visitante");
                            Console.WriteLine("16 - Consultar Nome do Visitante");
                            Console.WriteLine("0 - Voltar");

                            escolha2 = Convert.ToInt32(Console.ReadLine());

                            switch (escolha2)
                            {
                                case 13:
                                    //inserção de dados
                                    DALZoologico.InserirVisitante();
                                    //Comandos.InserirVis();

                                    break;
                                case 14:
                                    //deleção de dados
                                    DALZoologico.DeletarVisitante();
                                    //Comandos.DeletarVis();

                                    break;
                                case 15:
                                    //atualização de dados
                                    DALZoologico.AtualizarNomeVisitante();
                                    //Comandos.AtualizarVis();

                                    break;
                                case 16:
                                    // consulta dos dados parametrizada
                                    DALZoologico.GetVisitantesComParametro();
                                    //Comandos.ConsultarVis();

                                    break;
                                case 0:
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida. Tente novamente.");
                                    break;
                            }
                        }
                        break;
                    //////////////////////////////FIM MENU VISITANTE\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
                    case 4:
                        ///////////////////////////////// MENU ADMINISTRADOR\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
                        int escolha3 = -1;

                        while (escolha3 != 0)
                        {
                            Console.WriteLine("Escolha uma operação:");
                            Console.WriteLine("17 - Inserir Administrador");
                            Console.WriteLine("18 - Deletar Administrador");
                            Console.WriteLine("19 - Atualizar Nome do Administrador");
                            Console.WriteLine("20 - Consultar Nome do Administrador");
                            Console.WriteLine("0 - Sair");

                            escolha3 = Convert.ToInt32(Console.ReadLine());

                            switch (escolha3)
                            {
                                case 17:
                                    //inserção de dados
                                    DALZoologico.InserirAdministrador();
                                    //Comandos.InserirAdm();

                                    break;
                                case 18:
                                    //deleção de dados
                                    DALZoologico.DeletarAdministrador();
                                    //Comandos.DeletarAdm();

                                    break;
                                case 19:
                                    //atualização de dados
                                    DALZoologico.AtualizarNomeAdministrador();
                                    //Comandos.AtualizarAdm();

                                    break;
                                case 20:
                                    // consulta dos dados parametrizada
                                    DALZoologico.GetAdministradoresComParametro();
                                    //Comandos.ConsultarAdm();

                                    break;
                                case 0:
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida. Tente novamente.");
                                    break;
                            }
                        }
                        //////////////////////////////FIM MENU ADMINISTRADOR\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }

        }
    }
}
