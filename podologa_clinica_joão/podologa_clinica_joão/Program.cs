using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Threading;

using System.Diagnostics;

using System.Data;

namespace sistema_de_biblioteca

{

    internal class Program

    {

        public static class variaveis

        {

            public static string nome3;

            public static int ideia, DuracaoMinutos;

            public static decimal valor;



        }

        static void Main(string[] args)

        {

            int opcao = 0;

            while (opcao != 9)
            {

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine(@"
░█████╗░██╗░░░░░██╗███╗░░██╗██╗░█████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██║░░░░░██║████╗░██║██║██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝██║░░░░░██║██╔██╗██║██║██║░░╚═╝███████║  ██║░░██║█████╗░░
██║░░██╗██║░░░░░██║██║╚████║██║██║░░██╗██╔══██║  ██║░░██║██╔══╝░░
╚█████╔╝███████╗██║██║░╚███║██║╚█████╔╝██║░░██║  ██████╔╝███████╗
░╚════╝░╚══════╝╚═╝╚═╝░░╚══╝╚═╝░╚════╝░╚═╝░░╚═╝  ╚═════╝░╚══════╝

██████╗░░█████╗░██████╗░░█████╗░██╗░░░░░░█████╗░░██████╗░██╗░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║░░░░░██╔══██╗██╔════╝░██║██╔══██╗
██████╔╝██║░░██║██║░░██║██║░░██║██║░░░░░██║░░██║██║░░██╗░██║███████║
██╔═══╝░██║░░██║██║░░██║██║░░██║██║░░░░░██║░░██║██║░░╚██╗██║██╔══██║
██║░░░░░╚█████╔╝██████╔╝╚█████╔╝███████╗╚█████╔╝╚██████╔╝██║██║░░██║
╚═╝░░░░░░╚════╝░╚═════╝░░╚════╝░╚══════╝░╚════╝░░╚═════╝░╚═╝╚═╝░░╚═╝
");




                Console.ResetColor();


                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("1 - Cadastrar Cliente (Ficha Rápida)");

                Console.WriteLine("2 - Cadastrar podólogo");

                Console.WriteLine("3 - Cadastrar Procedimento/Serviço");

                Console.WriteLine("4 - Agendar Consulta");

                Console.WriteLine("5 - Listar Agendamentos");

                Console.WriteLine("6 - Exibir Todos os cadastros");

                Console.WriteLine("0 - Sair! ");

                Console.WriteLine(" =============================");

                Console.ResetColor();

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)

                {

                    case 1:

                        cadastrar_cliente();

                        break;

                    case 2:

                        funcao_podolog();

                        break;

                    case 3:

                        cadastrar_servico();

                        break;

                    case 4:

                        agendar_consulta();

                        break;

                    case 5:

                        listar_agendamentos();

                        break;

                    case 6:

                        todos_cadastros();

                        break;

                    case 0:

                        Console.Clear();

                        Console.WriteLine("Fechando programa! ");

                        return;


                }

            }

        }

        static void cadastrar_cliente()
        {

            int id;

            string telefone, nome, cpf, obsAnamnese;

            bool Possui_Diabetes;

            DateTime dataNascimento;

            Console.Clear();

            Console.ForegroundColor = (ConsoleColor)ConsoleColor.Green;

            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░██████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔══██╗
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░██║
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝

░█████╗░██╗░░░░░██╗███████╗███╗░░██╗████████╗███████╗
██╔══██╗██║░░░░░██║██╔════╝████╗░██║╚══██╔══╝██╔════╝
██║░░╚═╝██║░░░░░██║█████╗░░██╔██╗██║░░░██║░░░█████╗░░
██║░░██╗██║░░░░░██║██╔══╝░░██║╚████║░░░██║░░░██╔══╝░░
╚█████╔╝███████╗██║███████╗██║░╚███║░░░██║░░░███████╗
░╚════╝░╚══════╝╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝

");

            Console.ResetColor();

            Console.WriteLine("Digite o nome do cliente: ");

            nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF do cliente: ");

            cpf = Console.ReadLine();

            Console.WriteLine("Digite o Telefone:");

            telefone = Console.ReadLine();

            Console.WriteLine("Digite o id (identificador unico): ");

            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a data de nascimento do cliente: ");

            dataNascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("cliente possui diabetes: ");

            Possui_Diabetes = Console.ReadLine().ToUpper() == "sim";

            Console.WriteLine("O Cliente tem Alergias, Feridas ou Condições previas ? ");

            obsAnamnese = Console.ReadLine();

            Console.WriteLine("\n Cadastro realizado com sucesso !");

            Console.WriteLine("\n" + nome);

            Console.WriteLine("\n" + cpf);

            Console.WriteLine("\n" + telefone);

            Console.WriteLine("\n" + id);

            Console.WriteLine("\n" + dataNascimento);

            Console.WriteLine("\n" + Possui_Diabetes);

            Console.WriteLine("\n" + obsAnamnese);

            Thread.Sleep(3000);

        }

        static void funcao_podolog()

        {

            int id_pessoal;

            string nome1, registro_p, especialidade, telefone2;


            Console.Clear();

            Console.ForegroundColor = (ConsoleColor)ConsoleColor.Green;

            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░██████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔══██╗
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░██║
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝

██████╗░░█████╗░██████╗░░█████╗░██╗░░░░░░█████╗░░██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║░░░░░██╔══██╗██╔════╝░██╔══██╗
██████╔╝██║░░██║██║░░██║██║░░██║██║░░░░░██║░░██║██║░░██╗░██║░░██║
██╔═══╝░██║░░██║██║░░██║██║░░██║██║░░░░░██║░░██║██║░░╚██╗██║░░██║
██║░░░░░╚█████╔╝██████╔╝╚█████╔╝███████╗╚█████╔╝╚██████╔╝╚█████╔╝
╚═╝░░░░░░╚════╝░╚═════╝░░╚════╝░╚══════╝░╚════╝░░╚═════╝░░╚════╝░ 


 
 
");

            Console.ResetColor();

            Console.WriteLine("Digite o id do podologo (identificador profissional): ");

            id_pessoal = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do podologo: ");

            nome1 = Console.ReadLine();

            Console.WriteLine("Digite o numero do registro profissional do podologo: ");

            registro_p = Console.ReadLine();

            Console.WriteLine("Digite a especialidade do podologo (podopediatria, pé diabetico, esportiva): ");

            especialidade = Console.ReadLine();

            Console.WriteLine("Digite o telefone: ");

            telefone2 = Console.ReadLine();

            Console.WriteLine("\n Cadastro realizado com sucesso!!!");

            Console.WriteLine("\n" + id_pessoal);

            Console.WriteLine("\n" + registro_p);

            Console.WriteLine("\n" + especialidade);

            Console.WriteLine("\n" + telefone2);

            Thread.Sleep(3000);




        }

        static void cadastrar_servico()

        {


            Console.Clear();

            Console.ForegroundColor = (ConsoleColor)ConsoleColor.Green;

            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░██████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔══██╗
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░██║
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝

░██████╗███████╗██████╗░██╗░░░██╗██╗░█████╗░░█████╗░
██╔════╝██╔════╝██╔══██╗██║░░░██║██║██╔══██╗██╔══██╗
╚█████╗░█████╗░░██████╔╝╚██╗░██╔╝██║██║░░╚═╝██║░░██║
░╚═══██╗██╔══╝░░██╔══██╗░╚████╔╝░██║██║░░██╗██║░░██║
██████╔╝███████╗██║░░██║░░╚██╔╝░░██║╚█████╔╝╚█████╔╝
╚═════╝░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝░╚════╝░░╚════╝░


 
 
");


            Console.ResetColor();


            Console.WriteLine("Digite o ID do Procedimento:"); variaveis.ideia = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Nome do Procedimento:"); variaveis.nome3 = Console.ReadLine();

            Console.WriteLine("Digite a Duração de Minutos:"); variaveis.DuracaoMinutos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Valor do Serviço(em R$):"); variaveis.valor = decimal.Parse(Console.ReadLine());


            Console.WriteLine("\n Cadastro realizado com sucesso!!!");

            Console.WriteLine("\n" + variaveis.ideia);

            Console.WriteLine("\n" + variaveis.nome3);

            Console.WriteLine("\n" + variaveis.DuracaoMinutos);

            Console.WriteLine("\n" + variaveis.valor);

            Thread.Sleep(3000);



        }



        static void agendar_consulta()

        {

            Console.Clear();

            Console.ForegroundColor = (ConsoleColor)ConsoleColor.Green;

            Console.WriteLine(@" 
░█████╗░░██████╗░███████╗███╗░░██╗██████╗░░█████╗░██████╗░
██╔══██╗██╔════╝░██╔════╝████╗░██║██╔══██╗██╔══██╗██╔══██╗
███████║██║░░██╗░█████╗░░██╔██╗██║██║░░██║███████║██████╔╝
██╔══██║██║░░╚██╗██╔══╝░░██║╚████║██║░░██║██╔══██║██╔══██╗
██║░░██║╚██████╔╝███████╗██║░╚███║██████╔╝██║░░██║██║░░██║
╚═╝░░╚═╝░╚═════╝░╚══════╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝

░█████╗░░█████╗░███╗░░██╗░██████╗██╗░░░██╗██╗░░░░░████████╗░█████╗░
██╔══██╗██╔══██╗████╗░██║██╔════╝██║░░░██║██║░░░░░╚══██╔══╝██╔══██╗
██║░░╚═╝██║░░██║██╔██╗██║╚█████╗░██║░░░██║██║░░░░░░░░██║░░░███████║
██║░░██╗██║░░██║██║╚████║░╚═══██╗██║░░░██║██║░░░░░░░░██║░░░██╔══██║
╚█████╔╝╚█████╔╝██║░╚███║██████╔╝╚██████╔╝███████╗░░░██║░░░██║░░██║
░╚════╝░░╚════╝░╚═╝░░╚══╝╚═════╝░░╚═════╝░╚══════╝░░░╚═╝░░░╚═╝░░╚═╝


");

            Console.ResetColor();

            int id3, ClientID, Podogold, ProcedimentoID; DateTime DataHora; string Status;

            Console.WriteLine("Digite o Código do Agendamento:"); id3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Código do Paciente Cadastrado"); ClientID = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Código do Profissional Responsável:"); Podogold = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Código do Procedimento a ser realizado:"); ProcedimentoID = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Data e Horário Marcado:"); DataHora = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Status do Cadastro:"); Status = Console.ReadLine();


            Console.WriteLine("Cadastro realizado com sucesso!!!");

            Console.WriteLine("\n" + id3);

            Console.WriteLine("\n" + ClientID);

            Console.WriteLine("\n" + Podogold);

            Console.WriteLine("\n" + ProcedimentoID);

            Console.WriteLine("\n" + DataHora);

            Console.WriteLine("\n" + Status);


            Thread.Sleep(3000);

        }

        static void listar_agendamentos()
        {

            int id_agend, qtd_agend;

            string status_pagamento, canal_agend;

            Console.Clear();

            Console.ForegroundColor = (ConsoleColor)ConsoleColor.Green;

            Console.WriteLine(@" 
██╗░░░░░██╗░██████╗████████╗░█████╗░██████╗░
██║░░░░░██║██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░░░░██║╚█████╗░░░░██║░░░███████║██████╔╝
██║░░░░░██║░╚═══██╗░░░██║░░░██╔══██║██╔══██╗
███████╗██║██████╔╝░░░██║░░░██║░░██║██║░░██║
╚══════╝╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝

░█████╗░░██████╗░███████╗███╗░░██╗██████╗░░█████╗░███╗░░░███╗███████╗███╗░░██╗████████╗░█████╗░░██████╗
██╔══██╗██╔════╝░██╔════╝████╗░██║██╔══██╗██╔══██╗████╗░████║██╔════╝████╗░██║╚══██╔══╝██╔══██╗██╔════╝
███████║██║░░██╗░█████╗░░██╔██╗██║██║░░██║███████║██╔████╔██║█████╗░░██╔██╗██║░░░██║░░░██║░░██║╚█████╗░
██╔══██║██║░░╚██╗██╔══╝░░██║╚████║██║░░██║██╔══██║██║╚██╔╝██║██╔══╝░░██║╚████║░░░██║░░░██║░░██║░╚═══██╗
██║░░██║╚██████╔╝███████╗██║░╚███║██████╔╝██║░░██║██║░╚═╝░██║███████╗██║░╚███║░░░██║░░░╚█████╔╝██████╔╝
╚═╝░░╚═╝░╚═════╝░╚══════╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░░╚════╝░╚═════╝░


 
");


            Console.ResetColor();

            Console.WriteLine("Digite o codigo do agendamento: ");

            id_agend = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de agendamentos: ");

            qtd_agend = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o status do pagamento (pago ou pendente): ");

            status_pagamento = Console.ReadLine();

            Console.WriteLine("Digite por onde fez o agendamento(whatsapp, site, telefone ou presencial): ");

            canal_agend = Console.ReadLine();

            Console.WriteLine("CONCLUIDO!!!");

            Console.WriteLine("\n" + id_agend);

            Console.WriteLine("\n" + qtd_agend);

            Console.WriteLine("\n" + status_pagamento);

            Console.WriteLine("\n" + canal_agend);

            Thread.Sleep(3000);

        }

        static void todos_cadastros()
        {

            Console.Clear();

            Console.ForegroundColor = (ConsoleColor)ConsoleColor.Green;

            Console.WriteLine(@" 
███████╗██╗░░██╗██╗██████╗░██╗██████╗░
██╔════╝╚██╗██╔╝██║██╔══██╗██║██╔══██╗
█████╗░░░╚███╔╝░██║██████╦╝██║██████╔╝
██╔══╝░░░██╔██╗░██║██╔══██╗██║██╔══██╗
███████╗██╔╝╚██╗██║██████╦╝██║██║░░██║
╚══════╝╚═╝░░╚═╝╚═╝╚═════╝░╚═╝╚═╝░░╚═╝

░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░░██████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║╚█████╗░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║░╚═══██╗
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝██████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚═════╝░
 
 ");


            Console.ResetColor();


            Console.WriteLine("ID do Procedimento:" + variaveis.ideia);

            Console.WriteLine("Nome do Procedimento:" + variaveis.nome3);

            Console.WriteLine("Duração de Minutos:" + variaveis.DuracaoMinutos);

            Console.WriteLine(" Valor do Serviço(em R$):" + variaveis.valor);


            Thread.Sleep(3000);


        }


    }

}

