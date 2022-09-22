//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.WriteLine();
Console.WriteLine("Задача 64. Я выведу все натуральные числа в промежутке между заданными Вами M и N.");
int m64 = InputNumbers64("Введите натуральное число М: ");
int n64 = InputNumbers64("Введите натуральное число N: ");

int InputNumbers64(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

if (n64 > 0 && m64 > 0)
{   
  if (n64 > m64)
  {
    while (n64-2 > m64)
    {  
      Console.Write($"{m64+1}, ");
      m64++;
    }    
    Console.Write($"{m64+1} ");
  }
  else
  {
    while(m64-2 > n64)
    {  
      Console.Write($"{n64+1}, ");
      n64++;
    }    
    Console.Write($"{n64+1} ");
  }
}

else
{
  Console.WriteLine("Введено некорректное число (или числа).");
}
Console.WriteLine();

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine();
Console.WriteLine("Задача 66. Я найду сумму всех натуральных числа в промежутке между заданными Вами натуральными M и N.");
int m66 = InputNumbers66("Введите натуральное число М: ");
int n66 = InputNumbers66("Введите натуральное число N: ");

int InputNumbers66(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

if (n66 > m66)
{
    int CountNaturalSum(int m66, int n66)
    {
    if (m66 == n66)
        return n66;
    return n66 + CountNaturalSum(m66, n66 - 1);
    }
Console.WriteLine($"Сумма всех натуральных чисел от {m66} до {n66} = {CountNaturalSum(m66, n66)}");
}
else
{
    int CountNaturalSum(int n66, int m66)
{
    if (n66 == m66)
        return m66;
    return m66 + CountNaturalSum(n66, m66 - 1);
}
Console.WriteLine($"Сумма всех натуральных чисел от {m66} до {n66} = {CountNaturalSum(n66, m66)}");
}
System.Console.WriteLine();

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine();
Console.WriteLine("Задача 68. Я вычислю функцию Аккермана для заданных Вами неотрицательных чисел m и n.");
Console.WriteLine("Для возможности вычисления и демонстрации результата не используйте числа больше 3.");
int m68 = InputNumbers68("Введите неотрицательное число m: ");
int n68 = InputNumbers68("Введите неотрицательное число n: ");

int InputNumbers68(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int AkkermanFunction(int m68, int n68)
{
    if (m68 == 0)
    {
        return n68 + 1;
    }
    else if (m68 > 0 && n68 == 0)
    {
        return AkkermanFunction(m68 - 1, 1);
    }
    else
    {
        return AkkermanFunction(m68 - 1, AkkermanFunction(m68, n68 - 1));
    }
}
Console.Write($"A({m68},{n68}) = {AkkermanFunction(m68, n68)}"); 
System.Console.WriteLine();
  
    
