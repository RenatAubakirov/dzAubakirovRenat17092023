int a, b, c;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max<b) max = b;
if (max<c) max = c;
System.Console.WriteLine(max);