// See https://aka.ms/new-console-template for more information
Console.WriteLine("T2_GAAI_1184924");

Console.WriteLine("TAREA 2 EJERCICIO 1");
Console.WriteLine("CALCULO DE LA VELOCIDAD FINAL");

double Vf,Vi,a,t;

Console.WriteLine("Ingresa la Velocidad Inicial:");
Vi= Double.Parse(Console.ReadLine());
Console.WriteLine("Ingresa la Aceleracion:");
a= Double.Parse(Console.ReadLine());
Console.WriteLine("Ingresa el Tiempo:");
t= Double.Parse(Console.ReadLine());

Vf= Vi+(a*t);

Console.WriteLine("La Velocidad Final es "+Vf);
Console.ReadKey();

Console.WriteLine("TAREA 2 EJERCICIO 2");

Console.WriteLine("Gabriel Ajin - 1184924");

Console.Write("Ingrese un número: ");
    double cantidad = Convert.ToDouble(Console.ReadLine());

    int billetes100 = (int)(cantidad / 100);
    cantidad %= 100;

    int billetes50 = (int)(cantidad / 50);
    cantidad %= 50;

    int billetes20 = (int)(cantidad / 20);
    cantidad %= 20;

    int billetes10 = (int)(cantidad / 10);
    cantidad %= 10;

    int billetes5 = (int)(cantidad / 5);
    cantidad %= 5;
    int monedas1 = (int)(cantidad / 1);
    cantidad %= 1;
    int monedas25Centavos = (int)(cantidad / 0.25);
    cantidad %= 0.25;
    int monedas1Centavo = (int)(cantidad / 0.01);

                    
    Console.WriteLine($"{billetes100} de Q 100");
    Console.WriteLine($"{billetes50} de Q 50");
    Console.WriteLine($"{billetes20} de Q 20");
    Console.WriteLine($"{billetes10} de Q 10");
    Console.WriteLine($"{billetes5} de Q 5");
    Console.WriteLine($"{monedas1} de Q 1");
    Console.WriteLine($"{monedas25Centavos} de 25 centavos");
    Console.WriteLine($"{monedas1Centavo} de 1 centavo");