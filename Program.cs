
/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16


int first (int A, int B){
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result*=A;
    }
    return result;
}

Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int stepen = first(a,b);
Console.WriteLine($"Число {a} в степени числа {b} равняется "+ stepen );



/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12


  int summNumber(int num){
    int suum = Convert.ToString(num).Length; // переводим в число в строку
    int perem = 0;
    int result = 0;

    for (int i = 0; i < suum; i++){   //предположим что число 452 
      perem = num - num % 10; // из строки 452 убираем 2, остается 45
      result = result + (num - perem);//  452 - 45, в результат записываем 2
      num = num / 10;// остается 45 и идем по циклу возвращая значение
    }
   return result;
  }
Console.WriteLine("Введи любое число");
int sum = Convert.ToInt32(Console.ReadLine());
int Sum = summNumber(sum);
Console.WriteLine($"Сумма чисел в числе {sum} равняется " + Sum);

/*
Задача 29: Напишите программу, которая задаёт массив из произвольного элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/


Console.Write("Введите произвольные числа, разделенных запятой : ");
string? entertheNumbers = Console.ReadLine();

entertheNumbers = entertheNumbers + ",";    // дополнительня запятая для обозначения конца строки

// функция  создания и заполнения массива из строки
int[] ArrayOfNumbers(string strNew){ 

  int[] arrayOfNumbers = new int[1];    // инициализация массива из 1 элемента

  int j =0;

  for (int i = 0; i < strNew.Length; i++){
    string seriesNew1 = "";

    while (strNew[i] != ',' && i < strNew.Length){
      seriesNew1 += strNew[i];
      i++;
    }
    arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    // заполняет массив значениями из строки
    if (i < strNew.Length-1){
      arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();    // добавляет новый нулевой элемент в конец массива
    }
    j++;
  }
  return arrayOfNumbers;
}

// функция  вывода массива на печать 
void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count){
    Console.Write(coll[index]);
    index++;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 


string strNew = entertheNumbers;
int[] arrayOfNumbers =  ArrayOfNumbers(strNew);
PrintArry(arrayOfNumbers);