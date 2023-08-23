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
            /***************************/
            /****                   ****/
            /****    MILESTONE 1    ****/
            /****                   ****/
            /***************************/

            Console.WriteLine("MILESTONE 1: Noms Ciutats\n");

            /********* FASE 1 **********/

            string ciutat1, ciutat2, ciutat3, ciutat4, ciutat5, ciutat6;

            Console.Write("Introdueix el nom de la ciutat 1: ");
            ciutat1 = Console.ReadLine();
            Console.Write("Introdueix el nom de la ciutat 2: ");
            ciutat2 = Console.ReadLine();
            Console.Write("Introdueix el nom de la ciutat 3: ");
            ciutat3 = Console.ReadLine();
            Console.Write("Introdueix el nom de la ciutat 4: ");
            ciutat4 = Console.ReadLine();
            Console.Write("Introdueix el nom de la ciutat 5: ");
            ciutat5 = Console.ReadLine();
            Console.Write("Introdueix el nom de la ciutat 6: ");
            ciutat6 = Console.ReadLine();

            Console.WriteLine($"{ciutat1}, {ciutat2}, {ciutat3}, {ciutat4}, {ciutat5}, {ciutat6}");

            /********* FASE 2 **********/

            string[] arrayCiutats = { ciutat1, ciutat2, ciutat3, ciutat4, ciutat5, ciutat6 };

            //ordena les ciutats alfabeticament
            Array.Sort(arrayCiutats);

            Console.WriteLine("Noms de ciutats ordenades per ordre alfabètic:");
            foreach (string ciutat in arrayCiutats)
            {
                Console.WriteLine(ciutat);
            }

            /********* FASE 3 **********/

            string[] arrayCiutatsModificades = new string[arrayCiutats.Length];
            for (int i = 0; i < arrayCiutats.Length; i++)
            {
                //Replace canvia tots els caracters del string, en aquest cas 'a' per el caracter del segon parametre del a funcio
                arrayCiutatsModificades[i] = arrayCiutats[i].Replace('a', '4');
            }

            Console.WriteLine("Noms de ciutats modificades:");
            foreach (string ciutatModificada in arrayCiutatsModificades)
            {
                Console.WriteLine(ciutatModificada);
            }

            /********* FASE 4 **********/

            //array buit del tamany de arrayCiutats
            string[] arrayNomsInvertits = new string[arrayCiutats.Length];

            for (int i = 0; i < arrayCiutats.Length; i++)
            {
                //per a cada ciutat transformo l'string en chars i els poso al array de char
                char[] ciutatChars = arrayCiutats[i].ToCharArray();
                //inverteixo
                Array.Reverse(ciutatChars);
                //afegeixo la ciutat invertida ala rray buit de ciutats ingvertides
                arrayNomsInvertits[i] = new string(ciutatChars);
            }

            //les mostro
            Console.WriteLine("Noms de ciutats invertits:");
            foreach (string nomInvertit in arrayNomsInvertits)
            {
                Console.WriteLine(nomInvertit);
            }

            /***************************/
            /****                   ****/
            /****    MILESTONE 2    ****/
            /****                   ****/
            /***************************/

            Console.WriteLine("\nMILESTONE 2: Notes Alumnes\n");

            double[,] arrayNotes = new double[5, 3]; //5 alumnes, 3 notes


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Introdueix les notes per l'alumne {i + 1}:");
                //Introdueix 3 notes per teclat
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Nota {j + 1}: ");
                    //si no convertim a double no les deix afegir, ja que l'array es de doubles
                    arrayNotes[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            // per a cada un dels alumnes:
            for (int i = 0; i < 5; i++)
            {
                double sumaNotes = 0;
                //sumem les 3 notes
                for (int j = 0; j < 3; j++)
                {
                    sumaNotes += arrayNotes[i, j];
                }
                double mitjana = sumaNotes / 3;

                //Si mitjana es igual o superor a 5: Aprovat, si no suspes
                string resultat = mitjana >= 5 ? "Aprovat" : "Suspes";
                Console.WriteLine($"Alumne {i + 1}: Mitjana = {mitjana:F2}, {resultat}");
            }

            /***************************/
            /****                   ****/
            /****    MILESTONE 3    ****/
            /****                   ****/
            /***************************/

            Console.WriteLine("\nMILESTONE 3: Sequencia Fibonacci\n");

            Console.Write("Introdueix un numero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int a = 0, b = 1, c;
            Console.Write($"Secuencia de Fibonacci hasta {num}: ");
            Console.Write($"{a}, {b}");

            c = a + b;
            while (c <= num)
            {
                //imprimeixo el valor actual de la sequencia
                Console.Write(", " + c);

                //actualito valors
                a = b;
                b = c;
                c = a + b;
            }
        }
    } 

    class M4
    {
        public static void Execute()
        {
            /***************************/
            /****                   ****/
            /****     MILESTONE     ****/
            /****     1, 2 i 3      ****/
            /****                   ****/
            /***************************/

            Console.WriteLine("MILESTONE 1: Restaurant\n");

            /********* FASE 1 **********/
            const int MaximPlats = 5;
            int[] bitllets = { 500, 200, 100, 50, 20, 10, 5 };
            int preuTotal = 0;

            Dictionary<string, int> menu = new Dictionary<string, int>();

            /********* FASE 2 **********/
            for (int i = 0; i < MaximPlats; i++)
            {
                Console.Write($"Nom del plat {i + 1}: ");
                string plat = Console.ReadLine();

                Console.Write($"Preu:");
                int preu = int.Parse(Console.ReadLine());
                try
                {
                    menu.Add(plat, preu);
                }
                // error clave repetida
                catch (ArgumentException ex)
                {
                    i--;
                    Console.WriteLine($"Error: {ex.Message}. Clau ja existeix.");
                }
            }


            List<string> comanda = new List<string>();
            bool seguirDemanant = true;

            while (seguirDemanant)
            {
                Console.WriteLine("Menú:");
                foreach (var plat in menu)
                {
                    Console.WriteLine($"{plat.Key} | Preu: {plat.Value}e");
                }

                Console.Write("Introdueix el nom del plat que vols demanar: ");
                try
                {
                    string opcio = Console.ReadLine();
                    if (menu.ContainsKey(opcio))
                    {
                        comanda.Add(opcio);
                        preuTotal += menu[opcio];
                    }
                    else
                    {
                        throw new OpcioPlatIncorrectaException("Opció incorrecta");
                    }
                }
                catch (OpcioPlatIncorrectaException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                bool numeroCorrecte = true;
                //utilito el do while perque mentre l'usuari no premi 1 per seguir escollint o 0 per sortir, torni a repetir la pregunta
                do
                {
                    Console.Write("Vols seguir demanant? (1: Si / 0: No): ");
                    try
                    {
                        int continuar = int.Parse(Console.ReadLine());

                        //si ulusuari prem 0, no vol seguir demanant. Assigno numeroCorrecte a true per a sortir del do while
                        if (continuar == 0)
                        {
                            numeroCorrecte = true;
                            seguirDemanant = false;
                        }
                        // no modifico seguir demanant perque lusuari vol seguir demanant, pero si que assigno numeroCorrecte a true per a que surti del do while
                        else if (continuar == 1)
                        {
                            numeroCorrecte = true;
                        }
                        else if (continuar != 1)
                        {
                            //lanzo la excepcio
                            throw new ContinuarDemanantException("Opció incorrecta");
                        }
                    }
                    //assigno numero correcte a fals perque segueixi demanant una opcio valida
                    catch (FormatException)
                    {
                        numeroCorrecte = false;
                        Console.WriteLine("Opció incorrecta. Introdueix un número.");
                    }
                    catch (ContinuarDemanantException ex)
                    {
                        numeroCorrecte = false;
                        Console.WriteLine(ex.Message);
                    }
                } while (!numeroCorrecte);
            }

            /********* FASE 3 **********/

            Console.WriteLine("Comanda:");

            foreach (string plat in comanda)
            {
                Console.WriteLine(plat);
            }

            Console.WriteLine($"Preu total: {preuTotal}e");
        }

        class OpcioPlatIncorrectaException : Exception
        {
            public OpcioPlatIncorrectaException(string message) : base(message) { }
        }
        //excepcio que sols mostra un missatge
        class ContinuarDemanantException : Exception
        {
            public ContinuarDemanantException(string message) : base(message) { }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            M4.Execute();
        }
    }
}
