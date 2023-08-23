using System;

namespace Tarea24
{
    class M1
    {
        public static void Execute()
        {
            /***************************/
            /****                   ****/
            /****    MILESTONE 1    ****/
            /****                   ****/
            /***************************/

            Console.WriteLine("MILESTONE 1: Nom, data, anys de traspas\n");

            /********* FASE 1 **********/

            string nom, cognom1, cognom2;
            nom = "Albert";
            cognom1 = "Esponey";
            cognom2 = "Pique";

            int dia, mes, any;
            dia = 31;
            mes = 03;
            any = 2001;

            Console.WriteLine($"{nom} {cognom1} {cognom2}");
            Console.WriteLine($"{dia}/{mes}/{any}");

            /********* FASE 2 **********/

            const int anyTraspas = 1948;
            const int anyPerTraspas = 4;

            //anys de trasnaps entre 1948 i 2001
            int numAnys = any - anyTraspas;
            int numAnysTraspas = numAnys / anyPerTraspas;
            Console.WriteLine("Entre 1948 i el meu any de naixament (2001) hi han hagut " +  numAnysTraspas + " anys de traspas");

            /********* FASE 3 **********/

            Console.WriteLine("Anys de traspas desde 1948 fins al 2001:");

            // assigno a la i la constant anyTraspas, que es 1948
            bool esAnyTraspas = false;
            for (int i = anyTraspas; i <= any; i=i+4)
            {
                if(i == any)
                {
                    esAnyTraspas |= true;
                }
                Console.WriteLine(i);
            }

            string fraseTrue = "El meu any de naixament es un any de traspas";
            string fraseFalse = "El meu any de naixament NO es un any de traspas";

            if(esAnyTraspas)
            {
                Console.WriteLine(fraseTrue);
            }
            else
            {
                Console.WriteLine(fraseFalse);
            }

            /********* FASE 4 **********/

            string nomComplet = $"{nom} {cognom1} {cognom2}";
            string dataNaixament = $"{dia}/{mes}/{any}";

            Console.WriteLine($"El meu nom es {nomComplet}");
            Console.WriteLine($"Vaig neixer el {dataNaixament}");
            if (esAnyTraspas)
                Console.WriteLine(fraseTrue);
            else
                Console.WriteLine(fraseFalse);

            Console.WriteLine("\n\n");

            /***************************/
            /****                   ****/
            /****    MILESTONE 2    ****/
            /****                   ****/
            /***************************/

            Console.WriteLine("MILESTONE 2: cast de variables\n");

            double dec = 10.2222;

            int enter = (int)dec;
            float flo = (float)dec;
            string cadena = dec.ToString();

            Console.WriteLine("Double: " + dec);
            Console.WriteLine("Int: " + enter);
            Console.WriteLine("Float: " + flo);
            Console.WriteLine("String: " + cadena);

            Console.WriteLine("\n\n");

            /***************************/
            /****                   ****/
            /****    MILESTONE 3    ****/
            /****                   ****/
            /***************************/

            Console.WriteLine("MILESTONE 3: Invertir array\n");

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Array original:");

            //mostrar array
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            //guardo el primer valor a la variable auxiliar aux
            int aux = array[0];

            //vaig movent cada valor a la posicio anterior. No perdo el valor de la primera posicio perque l'he guardat a aux. [ROTACIO CAP A L'ESQUERRA]
            for (int i = 0; i < (array.Length - 1); i++)
            {
                array[i] = array[i + 1];
            }
            //Poso el valor de la primera posicio a la ultima
            array[array.Length - 1] = aux;

            Console.WriteLine("Array invertit:");
            //mostrar array
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }
    }

    class M2
    {
        public static void Execute()
        {
            /***************************/
            /****                   ****/
            /****    MILESTONE 1    ****/
            /****                   ****/
            /***************************/

            Console.WriteLine("MILESTONE 1: Lletres Repetides\n");

            /********* FASE 1 **********/

            char[] nom = {'A', 'l', 'b', 'e', 'r', 't'};

            foreach (char lletra in nom)
            {
                Console.WriteLine(lletra);
            }

            Console.WriteLine("\n");

            /********* FASE 2 **********/

            List<char> nomLlista = new List<char>(nom);

            foreach (char lletra in nomLlista)
            {
                if (Char.IsLetter(lletra))
                {
                    if ("aeiouAEIOU".Contains(lletra))
                    {
                        Console.WriteLine($"La {lletra} es una VOCAL");
                    }
                    else
                    {
                        Console.WriteLine($"La {lletra} es una CONSONANT");
                    }
                }
                else if (Char.IsDigit(lletra))
                {
                    Console.WriteLine("Els noms de persones no contenen numeros!");
                }
            }

            Console.WriteLine("\n");

            /********* FASE 3 **********/

            // els diccionaris tenen entrades. Cada entrade te la seva Key i el valor associat a aquesta key
            Dictionary<char, int> lletresContador = new Dictionary<char, int>();

            //recorro totes les lletres de la llista
            foreach (char lletra in nomLlista)
            {
                //comprovo si es una lletra
                if (Char.IsLetter(lletra))
                {
                    if (lletresContador.ContainsKey(lletra))
                    {
                        // Si ja existeix la lletra al diccionari incremento el valor de la key lletra
                        lletresContador[lletra]++;
                    }
                    else
                    {
                        // Si no existeix key que correspon a la lletra, al assignarli un valor l'estic creant automaticament
                        lletresContador[lletra] = 1;
                    }
                }
            }

            foreach (var entrada in lletresContador)
            {
                Console.WriteLine($"Lletra: {entrada.Key}, Repeticions: {entrada.Value}");
            }

            Console.WriteLine("\n");

            /********* FASE 4 **********/

            string cognom = "Esponey";
            List<char> cognomL = new List<char>(cognom);

            List<char> nomComplet = new List<char>();
            nomComplet.AddRange(nomLlista);
            nomComplet.Add(' '); //espia buit al mig
            nomComplet.AddRange(cognomL);

            Console.Write("Nom complet: ");
            foreach (char lletra in nomComplet)
            {
                Console.Write($"‘{lletra}’");
            }
            Console.WriteLine("\n\n");

            /***************************/
            /****                   ****/
            /****    MILESTONE 2    ****/
            /****                   ****/
            /***************************/

            Console.WriteLine("MILESTONE 2: bucles anidats\n");

            int alt = 5; 

            for (int i = 1; i <= alt; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");

            Console.WriteLine("MILESTONE 2: Piramide invertida\n");

            int altPiramide = 10;

            for (int i = altPiramide; i > 0; i--)
            {
                for (int j = 1; j <= altPiramide - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i * 2 - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n");

            /***************************/
            /****                   ****/
            /****    MILESTONE 3    ****/
            /****                   ****/
            /***************************/

            Console.WriteLine("MILESTONE 3: Rellotge\n");

            int hour = 0;
            int minutes = 0;
            int seconds = 0;

            while (true)
            {
                Console.WriteLine($"{hour:00}:{minutes:00}:{seconds:00}");
                Thread.Sleep(1000);

                // convertir el segons a minuts i minuts a hores quan arriben al limit
                seconds++;
                if (seconds == 60)
                {
                    seconds = 0;
                    minutes++;
                    if (minutes == 60)
                    {
                        minutes = 0;
                        hour++;
                        if (hour == 24)
                        {
                            hour = 0;
                        }
                    }
                }
            }
        }
    }

    class M3 
    { 
        public static void Execute()
        {

        }
    }

    class M4
    {
        public static void Execute()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            M2.Execute();
        }
    }
}
