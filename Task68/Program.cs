/*Напишите программу вычисления функции Аккермана с помощью рекурсии. 
  Даны два неотрицательных числа m и n.
  m = 2, n = 3 -> A(m,n) = 9
  m = 3, n = 2 -> A(m,n) = 29
*/

int InputInt(string output)
{
  Console.Write(output);
  return int.Parse(Console.ReadLine());
}

int m = InputInt("Задайте число m: ");
int n = InputInt("Задайте число n: ");
int functionAkkerman = Function(m, n);

int Function(int m, int n)
{
  if (m == 0) 
  {
    return n + 1;
  }
  else if (n == 0)
  { 
    return Function(m - 1, 1);
  }
  else 
  {
    return Function(m - 1, Function(m, n - 1));
  }
}

Console.Write($"Функция Аккермана = {functionAkkerman} ");