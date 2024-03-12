// Gabriel Alejandro Ajin Izaguirre
//1184924   
//FIBONACCI
Console.WriteLine("SEMAMA 9 - FIBONACCI");

            Console.Write("Ingrese un numero N menor de 0 ");
            int n = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;
            int c;

            Console.WriteLine("Los primeros " + n + " términos de la sucesión de Fibonacci son:");
            Console.Write(a + " " + b + " ");

            int count = 2;
            while (count < n)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
                count++;
            }

            Console.WriteLine();