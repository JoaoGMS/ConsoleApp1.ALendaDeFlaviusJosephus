using System;

namespace ConsoleApp1.ALendaDeFlaviusJosephus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool opcao;

            do
            {
                //https://www.youtube.com/watch?v=beFd1_AEKW4
                // nº de soldados = 2^ + L // Posição do sobrevivente = L * 2 + 1 // L= Nº de soldado - 2^
                int NDeSoldados3, L, PosicaoSobrevivente, NDeSoldados52, NDeSoldados63, NDeSoldados12341233;
                Console.WriteLine("");

                if (opcao 1)
                {
                    int  = Convert.ToInt32(strL);
                    int  = Convert.ToInt32(strN);
                    NDeSoldados3 = 3;
                    L = NDeSoldados3 - 2 ^ 1;
                    PosicaoSobrevivente = L * 2 + 1;

                    Console.WriteLine(PosicaoSobrevivente + "é a posição de sobrvivencia");

                }
            
                else if ( opcao 2)
                {
                    NDeSoldados52 = 52 ;
                    L = NDeSoldados52 - 2 ^5 ;
                    PosicaoSobrevivente = L * 2 + 1;
                    Console.WriteLine(PosicaoSobrevivente + "é a posição de sobrvivencia");

                }
                else if (opcao 3) 
                {

                    NDeSoldados63 = 63;
                    L = NDeSoldados63 - 2 ^ 5;
                    PosicaoSobrevivente = L * 2 + 1;

                    Console.WriteLine(PosicaoSobrevivente + "é a posição de sobrvivencia");

                }
                else if (opcao 4) 
                {
                    NDeSoldados12341233 =12341233 ;
                    L = NDeSoldados12341233 - 2 ^ 17;
                    PosicaoSobrevivente = L * 2 + 1;

                    Console.WriteLine(PosicaoSobrevivente + "é a posição de sobrvivencia");

                }

              //  int x = Convert.ToInt32(strx);
              //  int y = Convert.ToInt32(stry);





            } while (opcao == 1 || opcao == 2 ||opcao == 3 || opcao == 4)  ;
        }
    }
}
