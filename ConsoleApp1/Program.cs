using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string concatenacao = string.Empty;

            foreach (var item in FibonacciSerie(10))
            {
                concatenacao += item + "  ";
            }
            

            Console.WriteLine(concatenacao);
            Console.ReadKey();



        }

        /// <summary>
        /// conversão de min para horas
        /// </summary>
        /// <param name="hour"></param>
        /// <returns></returns>
        static string ConvertMinForHours(TimeSpan hour)
        {
            int minutos = -90;
            bool mostrarHoranegativa = minutos > 0 ? true : false;
            TimeSpan hours = TimeSpan.FromMinutes(minutos);
            string mostrar = hours.ToString(@"hh\:mm");
            if (!mostrarHoranegativa)
                mostrar = "-" + mostrar;
            return mostrar;
        }


        void CallMethodBubble()
        {
            string[] numeros = new string[5];
            numeros[0] = "122";
            numeros[1] = "22122";
            numeros[2] = "-1555";
            numeros[3] = "-445454";
            numeros[4] = "0";


            numeros = BubbleSort(numeros);

            string concatenacao = string.Empty;

            for (int i = 0; i < numeros.Length; i++)
            {
                concatenacao += numeros[i] + "   ";
            }


            Console.WriteLine(concatenacao);
        }
        /// <summary>
        /// Metodo de ordenação da bolha
        /// </summary>
        /// <param name="vetor"></param>
        /// <returns></returns>
        ///
        static string[] BubbleSort(string[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                for (int x = i + 1; x < vetor.Length; x++)
                {
                    if (int.Parse(vetor[i]) > int.Parse(vetor[x]))
                    {
                        string aux;
                        aux = vetor[x];
                        vetor[x] = vetor[i];
                        vetor[i] = aux;
                    }
                }
            }

            return vetor;
        }

        /// <summary>
        /// Fatorial com Recursao
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        static int FatorialComRecursao(int numero)
        {
            if (numero == 1)
                return 1;
            else
            {
                return numero * FatorialComRecursao(numero - 1);
            }
        }


        /// <summary>
        /// Serie de fibonacci
        /// </summary>
        /// <param name="termos"></param>
        /// <returns></returns>
        static string[] FibonacciSerie(int termos)
        {
            string[] series = new string[termos + 1];

            for (int i = 0; i < termos; i++)
            {
                if (i == 0 || i == 1)
                    series[i] = i.ToString();
                else
                    series[i] = (int.Parse(series[i - 2]) + int.Parse(series[i - 1])).ToString();
            }

            return series;
        }


    }
}
