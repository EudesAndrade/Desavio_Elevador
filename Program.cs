using ProjetoElevador.Models;
using System;

namespace ProjetoElevador
{
    internal class Program
    {
        //private const string Sair = "3";

        static void Main(string[] args)
        {

        Start:

            Elevador elevador = new Elevador();

            elevador.Inicializar();
            int sair = 0;

            Console.WriteLine(@"Deseja entrar no Elevador:
                    1 - Sim
                    2 - Não
                            ");
            int entarElevador = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (entarElevador)
            {
                case 1: elevador.Entrar(); break;
                case 2:
                    Console.WriteLine("---Até logo---");
                    Environment.Exit(entarElevador);
                    break;
                default:
                    Console.WriteLine("Escolha Inválida, escolha uma opção novamente");
                    goto Start;
            }

        Final:

            Console.WriteLine(@"Favor digite o que deseja fazer:
                    1 - Subir
                    2 - Descer
                    3 - Sair
                                ");

            int andar = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (andar)
            {
                case 1: elevador.Subir(); break;
                case 2: elevador.Descer(); break;
                case 3:
                    elevador.Sair(sair);
                    sair = elevador.Sair(sair);

                    if (sair == 1)
                    {
                        goto Final;
                    }
                    if (sair == 2)
                    {
                        Environment.Exit(andar);

                    }; break;
                default:
                    Console.WriteLine("Escolha Inválida, escolha uma opção novamente");
                    goto Final;
            }

            goto Final;
        }
    }
}
