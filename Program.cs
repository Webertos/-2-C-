/*
int Exponentiation(int num1, int num2)
{
  int result = 1;
  for(int i=1; i <= num2; i++){
    result = result * num1;
  }
    return result;
}
  int num1 = int.Parse(Console.ReadLine());
  int num2 = int.Parse(Console.ReadLine());

  int exponentiation = Exponentiation(num1, num2);
  Console.WriteLine(exponentiation);
*/



/*
int num = int.Parse(Console.ReadLine());

  int Sum(int num){
    
    int counter = Convert.ToString(num).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = num - num % 10;
      result = result + (num - advance);
      num = num / 10;
    }
   return result;
  }

int sum1 = Sum(num);
Console.WriteLine(sum1);
*/


Console.WriteLine($"\nЗадача 29. Ряд чисел преобразует в массив");
Console.Write("Введите ряд чисел, разделенных запятой : ");
string? seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ",";  
