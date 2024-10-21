using System;
using System.Threading; //para usar pausa
//se usar static System.Console não precisa usar o Console.Background

namespace MenuTodos //vetores, calculadora do portugol
{
    class Program
    {
        static void Menu(string[] args)
        {
            {
                int opc;

                Console.BackgroundColor = ConsoleColor.Red; //cor de fundo
                Console.ForegroundColor = ConsoleColor.Black; // cor do texto
                Console.Clear(); // colore os espaços em branco.

                Console.WriteLine(" ");
                Console.WriteLine("                                           " + "----- Menu Principal ----");
                Console.WriteLine("                                           " + "-------------------------");
                Console.WriteLine("                                           " + "--- [1] Cálculos --------");
                Console.WriteLine("                                           " + "--- [2] Entrevista ------");
                Console.WriteLine("                                           " + "--- [3] Par Impar -------");
                Console.WriteLine("                                           " + "--- [4] Comparador ------");
                Console.WriteLine("                                           " + "--- [5] Contador --------");
                Console.WriteLine("                                           " + "--- [6] Tabuada ---------");
                Console.WriteLine("                                           " + "--- [7] Vetores ---------");
                Console.WriteLine("                                           " + "-------------------------");
                Console.WriteLine("                                           " + "--- [8] Fim -------------");
                Console.WriteLine(" ");

                Console.Write("                                           Digite um número : ");
                opc = int.Parse(Console.ReadLine()); //ler opc int

                switch (opc)
                {

                    case 1:
                        static void calculos();
                        break;

                    case 2:
                        static void entrevista();
                        break;

                    case 3:
                        static void par_impar();
                        break;

                    case 4:
                        static void comparador();
                        break;

                    case 5:
                        static void contador();
                        break;

                    case 6:
                        static void tabuada();
                        break;

                    case 7:
                        static void vetores();
                        break;

                    case 8:
                        break;


                }
                while (opc < 9)
                {
                    Console.WriteLine("Opção Invalida");
                     static void Menu();

                }

                static void calculos(string[] args)
                {
                    int opc;

                    Console.Clear();
                    Console.WriteLine(" ");
                    Console.WriteLine("                                           " + "----- Menu Cálculos -----");
                    Console.WriteLine("                                           " + "-------------------------");
                    Console.WriteLine("                                           " + "--- [1] Soma ------------");
                    Console.WriteLine("                                           " + "--- [2] Subtração -------");
                    Console.WriteLine("                                           " + "--- [3] Multiplicação ---");
                    Console.WriteLine("                                           " + "--- [4] Divisão ---------");
                    Console.WriteLine("                                           " + "--- [5] Todos -----------");
                    Console.WriteLine("                                           " + "-------------------------");
                    Console.WriteLine("                                           " + "--- [6] Voltar ----------");
                    Console.WriteLine(" ");

                    Console.Write("                                           Digite um número : ");
                    opc = int.Parse(Console.ReadLine());

                    switch (opc)
                    {

                        case 1:
                            static void soma();
                            break;

                        case 2:
                            static void subtracao();
                            break;

                        case 3:
                            static void multiplicacao();
                            break;

                        case 4:
                            static void divisao();
                            break;

                        case 5:
                            static void todos_calc();
                            break;

                        case 6:
                            static void Main();
                            break;

                    }
                    while (opc < 7)
                    {
                        Console.WriteLine("Opção Invalida");
                         static void calculos();

                    }

                    static void vetores(string[] args)
                    {
                        int opc;

                        Console.Clear();
                        Console.WriteLine(" ");
                        Console.WriteLine("                                           " + "-------- Vetores --------");
                        Console.WriteLine("                                           " + "-------------------------");
                        Console.WriteLine("                                           " + "--- [1]  Dia e Mês ------");
                        Console.WriteLine("                                           " + "--- [2]  Sigla e Estado -");
                        Console.WriteLine("                                           " + "--- [3]  Extenso Núm ----");
                        Console.WriteLine("                                           " + "--- [4]  Analise Núm ----");
                        Console.WriteLine("                                           " + "-------------------------");
                        Console.WriteLine("                                           " + "--- [5] Voltar ----------");
                        Console.WriteLine(" ");

                        Console.Write("                                           Digite um número : ");
                        opc = int.Parse(Console.ReadLine());

                        switch (opc)
                        {

                            case 1:
                                static void dia_mes();
                                break;

                            case 2:
                                static void sigla_estado();
                                break;

                            case 3:
                                static void extenso_num();
                                break;

                            case 4:
                                static void analisa_num();
                                break;

                            case 5:
                                static void Main();
                                break;

                        }
                        while (opc < 6)
                        {
                            Console.WriteLine("Opção Invalida");
                             static void vetores();

                        }

                        //menu 1 funções
                        static void entrevista(string[] args) //entrevista
                        {
                            string nome, sobrenome, resp;
                            int idade;

                            Console.Clear();
                            Console.WriteLine("Qual seu nome?");
                            nome = Console.ReadLine();
                            Thread.Sleep(800);

                            Console.Clear();
                            Console.WriteLine("Qual seu sobrenome?");
                            sobrenome = Console.ReadLine();
                            Thread.Sleep(800);

                            Console.Clear();
                            Console.WriteLine("Qual sua idade?");
                            idade = int.Parse(Console.ReadLine());
                            Thread.Sleep(800);

                            Console.WriteLine("Posso te apresentar?");
                            resp = Console.ReadLine();

                            if (resp == "s")
                            {
                                Console.WriteLine("Olá você é " + nome + " " + sobrenome + " e tem " + idade + " anos de vida !");
                            }
                            else{
                                Console.WriteLine("Tudo bem, voltando ao menu anterior");
                                static void Main();
                            }

                            static void par_impar(string[] args)
                            {
                                int num1, num2;

                                Console.WriteLine("Escreva o primeiro número : ");
                                num1 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Escreva o primeiro número : ");
                                num2 = int.Parse(Console.ReadLine());

                                if (num1 % 2 == 0) 
                                {
                                    Console.WriteLine("O número " + num1 + " é par");
                                }

                                else if (num1 % 2 != 0)
                                {
                                    Console.WriteLine("O número " + num1 + " é impar");
                                }

                                if (num2 % 2 == 0)
                                {
                                    Console.WriteLine("O número " + num1 + " é par");
                                }

                                else if(num2 % 2 != 0){
                                    Console.WriteLine("O número " + num1 + " é impar");
                                }
                            }

                        }

                    }

                }
            }
        }
            
    }
}
