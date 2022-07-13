/* Zadacha1
int a,b;
Console.WriteLine( "Введите два числа : ");
a = Convert.ToInt32(Console.ReadLine()); 
b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
  Console.WriteLine( "{0} Наибольшее число", a);
}
else
{
  Console.WriteLine( "{0} Наибольшее число", b );
}
*/

/* Zadacha2
int a,b,c;
Console.WriteLine ("Введите три числа");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max < b)
{
  max = b;
  
}
  if (max < c)
  {
    max = c; 
    
  }
Console.WriteLine(max);
*/

/* Zadacha3
int number = 55;
if (number % 2 == 0) Console.WriteLine ("число четное");
else Console.WriteLine (" число нечетное");
*/

/* Zadacha4
int number = 11;
int count = 1;
while ( count <= number)
{
 if (count % 2 == 0) Console.WriteLine(count);
  count++;  
}  
*/