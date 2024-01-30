// See https://aka.ms/new-console-template for more information
Console.WriteLine("PENSAMIENTO COMPUTACIONAL");

#region
//EJERCICIO 1
Console.WriteLine("EJERCICIO NO.1");
int a = 3;
int b = a++;
Console.WriteLine($"a es {a}, b es {b}");
#endregion

#region
//EJERCICIO 2
Console.WriteLine("");
Console.WriteLine("EJERCICIO NO.2");
int c = 3;
int d = ++c;

Console.WriteLine($"c is {c}, d is {d}");
#endregion
#region
//EJERCICIO 3
Console.WriteLine("");
Console.WriteLine("EJERCICIO NO.3");
int e = 1; 
int f = 3;
Console.WriteLine($"e is {e},f is {f}");
Console.WriteLine($"e + f = {e+f}");
Console.WriteLine($"e - f = {e + f}");
Console.WriteLine($"e * f = {e * f}");
Console.WriteLine($"e / f = {e / f}");
Console.WriteLine($"e % f = {e % f}");
double g = 11.0;
Console.WriteLine($"g is {g:N1}, f is {f}");
Console.WriteLine($"g / f= {g / f}");
#endregion
#region
//EJERCICIO 4
Console.WriteLine("");
Console.WriteLine("EJERCICIO NO.4");

int p = 6;
p += 3; //Equivalent to: p = p + 3;
p -= 3; //Equivalent to: p = p - 3;
p *= 3; //Equivalent to: p = p * 3;
p /= 3; //Equivalent to: p = p / 3;
#endregion
#region
//EJERCICIO 5
Console.WriteLine("");
Console.WriteLine("EJERCICIO NO.5");

string? authorName = Console.ReadLine();

//Prompt user to enter an autho name.
//The maxLeght variable will be the length of AuthorName if it is
//not null, or 30 if author name is null.
int maxLength= authorName?.Length ?? 30;

//The authorName variable will be "unknown" if authorName was null.
authorName ??= "unknown";
#endregion
#region
//EJERCICIO 6
Console.WriteLine("");
Console.WriteLine("EJERCICIO NO.6");

bool z = true;
bool x = false;

Console.WriteLine($"AND | z | x");
Console.WriteLine($"z | {z & x,-5} | {z & x,-5} ");
Console.WriteLine($"x | {x & z,-5} | {x & z,-5} ");
Console.WriteLine();
Console.WriteLine($"OR | z | x");
Console.WriteLine($"z | {z | x,-5} | {z | x,-5} ");
Console.WriteLine($"x | {x | z,-5} | {x | z,-5} ");
Console.WriteLine();
Console.WriteLine($"XOR | z | x");
Console.WriteLine($"z | {z ^ x,-5} | {z ^ x,-5} ");
Console.WriteLine($"x | {x ^ z,-5} | {x ^ z,-5} ");
Console.WriteLine();
#endregion

#region
//EJERCICIO 7
Console.WriteLine("");
Console.WriteLine("EJERCICIO NO.7");

Console.WriteLine();
int w = 10;
int o = 6;

Console.WriteLine($"Expression | Decimal | Binary");
Console.WriteLine($"--------------------------------");
Console.WriteLine($"w | {w,7} | {w:B8}");
Console.WriteLine($"o | {o,7} | {o:B8}");
Console.WriteLine($"w & o | {w & o,7} | {w & o:B8}" );
Console.WriteLine($"w | o | {w | o,7} | {w | o:B8}");
Console.WriteLine($"w ^ o | {w ^ o,7} | {w ^ o:B8}");
#endregion
