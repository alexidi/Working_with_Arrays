﻿Console.Clear();
//Ввод пользователем размерности массива
Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
string[] stringArray = new string[m];

//Ввод данных в массив.
void array(string[] stringArray)
{
  for (int i = 0; i < stringArray.Length; i++)
  {
    Console.WriteLine($"Введите {i + 1} элемент массива");
    stringArray[i] = Console.ReadLine();
  }
}
//Определяем строки с <=3 символами
string[] count(string[] stringArray)
{
  int n = 0;
  for (int i = 0; i < stringArray.Length; i++)
  {
    if (stringArray[i].Length <= 3)
      n++;
  }
  //Записываем найденные строки с <=3 элементами в новый массив
  string[] rez = new string[n];
  int j = 0;
  for (int i = 0; i < stringArray.Length; i++)
  {
    if (stringArray[i].Length <= 3)
    {
      rez[j] = stringArray[i];
      j++;
    }
  }
  return rez;
}
//Выводим массив со строками с <=3 элементами на экран
void printA(string[] stringArray)
{
  Console.Write("[");
  for (int i = 0; i < stringArray.Length; i++)
  {
    Console.Write($"‘{stringArray[i]}’ ");
  }
  Console.Write("]");
}
array(stringArray);
printA(count(stringArray));
