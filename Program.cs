using System;

namespace MeuApp {
    class Program {
        static void Main(string[] args)
        {
            Menu();

        }

        static void Menu()
        {
            // Console.Clear();
            Console.WriteLine("Escolha a operação");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtracao");
            Console.WriteLine("3 - Divisao");
            Console.WriteLine("4 - Multiplicacao");

            short res = short.Parse(Console.ReadLine());

            if(res >= 5 || res <= 0){
                Console.WriteLine("Opção inválida");
                Console.WriteLine("------------------");
                Menu();
               
            }

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            switch(res)
            {
                case 1:
                        Soma(v1, v2);
                        break;
                case 2:
                        Subtracao(v1, v2);
                        break;
                case 3:
                        Divisao(v1, v2);
                        break;
                case 4:
                        Multiplica(v1, v2);
                        break;
            }
            
        }

 
        static void Soma(float v1, float v2)
        {
            float resultado = v1 + v2;


            Console.WriteLine("O resultado da soma é " + resultado);
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
    
        static void Subtracao(float v1, float v2)
        {
            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();
            Menu();
        }
    
        static void Divisao(float v1, float v2)
        {
            float resultado = v1 / v2;

            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
            Menu();
        }
    
        static void Multiplica(float v1, float v2)
        {
            float resultado = v1 * v2;

            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.ReadKey();
            Menu();
        }
    

     }


 }