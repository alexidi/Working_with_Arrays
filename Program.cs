Console.Clear();
//Создаем блок кода для ввода пользователем размерности массива
Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
string [] stringArray = new string [m];

//Ввод данных в массивы.
void array(string [] stringArray)
{
  for (int i = 0;i<stringArray.Length;i++)
  {
     Console.WriteLine($"Введите {i+1} элемент массива");
     stringArray[i] = Console.ReadLine();
  }
}
//Определяем массивы с <=3 элемента
string [] count(string [] stringArray)
{
  int n = 0;
  for (int i = 0;i<stringArray.Length;i++)
  {
    if(stringArray[i].Length <=3)
    n++;
  }
  //Записываем найденные массивы с <=3 элементами в новый массив
  string [] rez = new string [n];
  int j = 0;
  for (int i = 0;i<stringArray.Length;i++)
  {
    if(stringArray[i].Length <=3)
    {
        rez[j] = stringArray[i];
        j++;
    }
  }
  return rez;
}
//Выводим массивы с <=3 элементами на экран
void printA(string [] stringArray)
{
    Console.Write("[");
    for (int i = 0;i<stringArray.Length;i++)
    {
    Console.Write($"‘{stringArray[i]}’ ");
    }
    Console.Write("]");
}
array(stringArray);
printA(count(stringArray));
