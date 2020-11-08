using System;
using System.Collections.Generic;

namespace LamdasNET
{
    class Program
    {
        static void Main(string[] args)
        {



           



        }



        #region Metodos

        public static void PrimeraPrueba()
        {
            List<int> numeros = new List<int>();

            numeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            //List<int> numPares = numeros.FindAll(i => (i % 2) == 0);

            //foreach (int n in numPares)
            //{

            //    Console.WriteLine(n);
            //}


            List<int> numPares = numeros.FindAll((i) =>
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " Un par");
                    return true;
                }
                else
                {
                    Console.WriteLine(i + " Un impar");
                    return false;
                }

            });



        }


        #endregion

    }
}
