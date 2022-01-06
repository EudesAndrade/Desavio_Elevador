using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Models
{
    public class Elevador
    {
        int total_Andares;
        int capac_Pessoas;
        int pessoas_Elevador;
        int andar_Atual;
        public int AndarCorrent = 0;

        //Método Inicializar serve para dar boas vindas no elevador!
        public void Inicializar()
        {
            Console.WriteLine("  Seja bem vindo!!!\n");
           // Console.WriteLine("                       ");
            Console.WriteLine("  Qual é a capacidade do elevador?\n");
            capac_Pessoas = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("  Quantos andares tem o prédio?");
            total_Andares = int.Parse(Console.ReadLine());
            Console.Clear();
        }

        //Método Entrar atribui uma pessoa no elevador caso ainda caiba alguém!
        public void Entrar() 
        {
            if (pessoas_Elevador < capac_Pessoas)
            {
                pessoas_Elevador++;
                Console.WriteLine( pessoas_Elevador + " Pessoas no Elevador.");
            }
            else
            {
                Console.WriteLine("Desculpe, Elevador atingiu a capacidade máxima.");
            }

        }

        //Método Sair subtrai uma pessoa no elevador caso não esteja vazio!
        public int Sair(int andarDigitado) 
        {
            if (pessoas_Elevador > 0)
            {
                pessoas_Elevador--;
                andarDigitado = 1;
                Console.WriteLine(pessoas_Elevador + " Pessoas no Elevador.");
            }
            else if (pessoas_Elevador == 0 || pessoas_Elevador < 0)
            {
                Console.WriteLine("!! Elevador está vazio !!");
                Console.WriteLine("!! obrigado por usar o Elevador!!");
                andarDigitado = 2;

            }
            return andarDigitado;
        }

        //Método Subir serve para subir um andar por vez no elevador!
        public void Subir()
        {
            if (andar_Atual >= total_Andares)
            {
                Console.WriteLine("Voce já está no último andar, deseja descer ou subir?");
            }
            else
            {
                andar_Atual++;
                //Stop(andar_Atual);
                Console.WriteLine("Voce está no andar: " + andar_Atual);
            }


        }

        //Método Descer serve para descer um andar por vez no elevador!
        public void Descer()
        {
            if (andar_Atual == 0)
            {
                Console.WriteLine("Voce já está no Térreo, deseja subir ou sair?");
            }
            else
            {
                andar_Atual--;
                //Stop(andar_Atual);
                Console.WriteLine("Voce já está no andar: " + andar_Atual);
            }
        }
    }
}
