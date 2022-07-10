/*Задача 64: Задайте значение N. 
  Напишите программу, которая выведет все натуральные числа в промежутке от N до 1
  N = 5 -> "5, 4, 3, 2, 1"
  N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int InputInt(string output)
{
  Console.Write(output);
  return int.Parse(Console.ReadLine());
}

int numbers = InputInt("Введите число: ");
int count = 1;
NaturalNumber(numbers, count);

void NaturalNumber(int numbers, int count)
{
  if (count < numbers)
  NaturalNumber(numbers, count + 1);
  Console.Write(count + ", " );
  return;
}