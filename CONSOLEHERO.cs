using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace exercicios
{
    internal class Program
    {


        static void Main(string[] args)
        {
            // BOAS VINDAS AO JOGADOR

            EscreveComEfeito("****** BEM-VINDA AO CONSOLE HERO ******");
            EscreveComEfeito("Qual é o seu nome, heroína?");

            string nome = (Console.ReadLine());

            EscreveComEfeito($"\nSeja bem-vinda {nome}! Agora, escolha sua classe: ");

            
            Console.WriteLine("1- Guerreira");
            Console.WriteLine("2- Bruxa");
            Console.WriteLine("3- Hacker\n");

            Console.WriteLine("\nDigite o numero da sua classe: ");

            int escolhaClasse = int.Parse(Console.ReadLine());

            string classes = "";

            switch (escolhaClasse)
            {
                case 1:
                    classes = "Guerreira";
                    break;
                case 2:
                    classes = "Bruxa";
                    break;
                case 3:
                    classes = "Hacker";
                    break;
                default:
                    classes = "Cidadã Comum - sem classe nenhuma";
                    break;
            }

            Console.WriteLine($"Perfeito {nome}, você agora é uma {classes}\nPrepare-se para sua primeira missão.....\n");

            MissaoSoma();
            Console.ReadLine();
            MissaoMenu();
            Console.ReadLine();
            MissaoPedrasMagicas();
            Console.ReadLine();
            MissaoPortal();
            Console.ReadLine();
            MenuMissao();
            Console.ReadLine();
          



        }

        static void MissaoSoma()
        {

            EscreveComEfeito("Missão 1 - A Soma Sagrada!");
            EscreveComEfeito("Você encontrou um cofre antigo... e ele tem um engima...\n\nPara abri-lo você precisa somar dois numeros mágicos...\n");
            EscreveComEfeito("Digite o primeiro numero: ");

            int num1 = int.Parse(Console.ReadLine());

            EscreveComEfeito("Digite o segundo numero: ");

            int num2 = int.Parse(Console.ReadLine());

            int resultadoSoma = num1 + num2;

            EscreveComEfeito($"A soma é {resultadoSoma}");
            Console.WriteLine("\n**********************************************************");
            EscreveComEfeito("Parabéns, o cofre se abriu, você ganhou um Elixir da Lógica");
            Console.WriteLine("************************************************************\n");

            EscreveComEfeito("Aperte ENTER para a próxima missão....");
        }

        static void MenuPergaminho()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            EscreveComEfeito(@"
╔══════════════════════════════════════╗
║                 PERGAMINHO           ║
║   Escolha seu destino, heroína Ana:  ║
║                                      ║
║   1 - Beber uma poção misteriosa     ║
║   2 - Entrar em uma masmorra escura  ║
║   3 - Fugir pela janela da taverna   ║
╚══════════════════════════════════════╝
                                ");

            Console.ResetColor();

            

        }

        static void EscreveComEfeito(string texto, int velocidade = 50)
        {
            foreach (char c in texto)
            {
                Console.Write(c);
                Thread.Sleep(velocidade); // milissegundos
            }
            Console.WriteLine();
        }

        static void EscreveComEfeitoLento(string texto, int velocidade = 150)
        {
            foreach (char c in texto)
            {
                Console.Write(c);
                Thread.Sleep(velocidade); // milissegundos
            }
            Console.WriteLine();
        }

        static void MissaoMenu()

        {
            Console.Clear();
            EscreveComEfeito("Você encontra um pergaminho com três escolhas....");
            MenuPergaminho();
            EscreveComEfeito("Digite sua escolha: (1, 2 ou 3)");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    EscreveComEfeitoLento("Você bebeu a poção.... agora está falando em binário 0110010101 ahahahahaha ");
                    break;
                case "2":
                    EscreveComEfeitoLento("Você entra na masmorra e.......... encontra um bug ancestral (boa sorte)");
                    break;
                case "3":
                    EscreveComEfeitoLento("Você foge pela janela.... tropeça em um goblin e ...... ganha XP uhul");
                    break;
                default:
                    Console.WriteLine("Escolha inválida, o universo não entendeu o que você quer!!!");
                    break;

            }

            EscreveComEfeito("\n\nAperte ENTER para a próxima missão....");

        }

        static void MissaoPedrasMagicas()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
╔════════════════════════════════════════════╗
║           CAVERNA DOS NÚMEROS MÁGICOS      ║
║                                            ║
║  Três pedras brilham intensamente.         ║
║  Qual delas possui o MAIOR poder?          ║
╚════════════════════════════════════════════╝
");

            Console.ResetColor();

            Console.WriteLine("Digite o valor da pedra 1: ");
            int pedra1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da pedra 2: ");
            int pedra2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da pedra 3: ");
            int pedra3 = int.Parse(Console.ReadLine());

            int maior;

            if (pedra1 >= pedra2 && pedra1 >= pedra3)
            {
                maior = pedra1;
            }
            else if (pedra2 >= pedra1 && pedra2 >= pedra3)
            {
                maior = pedra2;
            }
            else
            {
                maior = pedra3;
            }

            Console.ForegroundColor = ConsoleColor.Green;

            EscreveComEfeito($"\n\nA Pedra com maior poder tem o valor {maior}");
            EscreveComEfeito("A porta mágica se abre.....");
            EscreveComEfeito("Você já pode seguir em frente:)");

            Console.ResetColor();
            EscreveComEfeito("\n\nAperte ENTER para a próxima missão....");

        }

        static void MissaoPortal()
        {
            Console.Clear();

            EscreveComEfeito("Você deverá conjurar um feitiço para abrir o portal mágico......\n\n");
            EscreveComEfeito("Digite a o feitiço que deseja conjurar: ");
            string feitiço = Console.ReadLine();

            EscreveComEfeito("Quantas vezes você deve dizer esse feitiço para que ele abra o portal?\n");
            EscreveComEfeito("Digite o numero de vezes: ");
            int vezes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= vezes; i++)
            {
                EscreveComEfeito($" {i} - {feitiço}");
            }

            EscreveComEfeito("O portal foi aberto\n");
            EscreveComEfeitoLento("Atravessando.........\n");
            EscreveComEfeito("\n\nPressione ENTER para atravessar....");

            Console.ReadLine();

        }

        static void MenuMissao()
            { Console.Clear();

            EscreveComEfeito("Você atravessou o portal e chegou em uma nova dimensão!!\n");
            EscreveComEfeito("Agora você possui três escolhas......");

            int escolha = -1;

            while (escolha != 0)
            {
                EscreveComEfeito("Escolha a sua ação com sabedoria...\n");
                EscreveComEfeito("1- Explorar a floresta misteriosa\n");
                EscreveComEfeito("2- Entrar na caverna sombria\n");
                EscreveComEfeito("3- Voltar para o mundo real (sair)\n");

                Console.WriteLine("Digite o numero da sua escolha:");
                bool entradaValida = int.TryParse(Console.ReadLine(), out escolha);

                if (!entradaValida)
                {
                    EscreveComEfeito("Opçao invalidade, tente digitando um numero, derrrr\n");
                    escolha = -1;
                    continue;
                }

                switch (escolha)
                {
                    case 1:
                        MissaoFloresta();
                            break;
                    case 2:
                        MissaoCaverna();
                            break;
                    case 3:
                        EscreveComEfeito("\n Você retornou para casa em segurança");
                        break;
                    default:
                        EscreveComEfeito("Opção inválida, escolha e digite novamente");
                        escolha = -1;
                            break;
                }
                


            }



        }

        static void MissaoFloresta()
        {
            Console.Clear();
            EscreveComEfeito("Você encontra uma árvore falante....\n");
            EscreveComEfeito("A árvore te propõe um enigma....\n Ela diz:\n\n");
            EscreveComEfeito("Ei, jovem aventureira, me digas...\nVocê sabe o que é verde e fica no canto da sala?\n");

            Console.WriteLine("1- Um jacaré pensativo");
            Console.WriteLine("2- Uma samambaia");
            Console.WriteLine("3- O Hulk fazendo xixi\n");
            EscreveComEfeito("Digite o numero corre´spondente a sua escolha: \n");

            int resposta = int.Parse(Console.ReadLine());

            if (resposta == 2)
            {
                EscreveComEfeito("Resposta correta!!! A Árvore falante te entrega uma maçã dourada!\n");
            }
            else
            {
                EscreveComEfeito("Errado!!! A árvore te transforma em planta.\n");
            }


        }

        static void MissaoCaverna()
        {
            Console.Clear();
            EscreveComEfeito("Você entrou na caverna e encontrou o morcego!\n\nM-m-mas.......\n\n Ele é GIGANTE!!!\n");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(@"
          /\                 /\
         /  \_____/  \
        (               )
         \___     ___/
             \   /
             (o o)
     ---oooO---(_)---Oooo--- 
    \n\n");
            Console.WriteLine("Morcegão: ");
            EscreveComEfeito("Testarei sua memória heroína... Decore a sequencia!");


            Random rnd = new Random();
            string[] sequencia = new string[5];
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < sequencia.Length; i++)
            {
                int index = rnd.Next(alfabeto.Length);
                sequencia[i] = alfabeto[index].ToString();

            }

            Console.WriteLine();

            foreach (string letra in sequencia)
            {
                Console.WriteLine(letra + "");
                Thread.Sleep(500);
            }

            Thread.Sleep(3000);
            Console.Clear();


            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Morcegão: ");
            EscreveComEfeito("Digite a sequencia que você viu, separada por espaço:\n");
            Console.ResetColor();

            string resposta = Console.ReadLine();

            string sequenciaCerta = string.Join("", sequencia);

            if (resposta.Trim().ToUpper() == sequenciaCerta)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                EscreveComEfeito("Hmmm... Sua mente é afiada como presas de vampiro! Avance!");
            } else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                EscreveComEfeito("HAHAHA! Você tem memória de peixe... E por falar em peixe.... Acho que agora você será o meu jantar!!!\n\n");
            }

            Console.ResetColor();

            Console.ReadLine();

        }

        }
    }


















