//  Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно первому, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно.



Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
 int c = a % b;
    if (c == 0)
   {
   Console.Write(a + ", ");
   Console.Write(b + " -> кратно");
  }
   else
   {
  Console.Write(a + ", ");   
 Console.Write(b + " -> не кратно, остаток " + c);
   } 
  



