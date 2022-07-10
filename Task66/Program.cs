/*Задача 66: Задайте значения M и N. 
  Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
  M = 1; N = 15 -> 120
  M = 4; N = 8. -> 30
*/
int InputInt(string output)
{
  Console.Write(output);
  return int.Parse(Console.ReadLine());
}

int m = InputInt("Задайте число m: ");
int n = InputInt("Задайте число n: ");
int sum = 0;
Summa(m, n, sum);

void Summa(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов = {sum} ");
    return;
  }
  Summa(m, n - 1, sum);
}
