/*int randomNumber = new Random().Next(10, 100);
int num1 = randomNumber % 10;
int num2 = randomNumber / 10;
System.Console.WriteLine("randomNumber");
System.Console.WriteLine (num1 > num2 ? num1 : num2);
 */


/*
	int num1 = int.Parse(Console.ReadLine());
	int Length = num1.ToString().Length;
	if (Length == 3) 
    {
		int result = ( num1/10 ) % 10;
		Console.WriteLine($"The second digit is {result}");
	} 
    */


/*int Day = int.Parse(Console.ReadLine());
if (Day >= 1 && Day <=7) 
{
	if (Day >= 6) 
    {
		Console.WriteLine("Выходной");
	} 
    else {
		Console.WriteLine("Рабочий день");
	}
} 
*/

int num1 = int.Parse(Console.ReadLine());
int Length2 = num1.ToString().Length;
if (Length2 >= 3) 
{
	while (num1 > 999)
	{
		num1 = num1 / 10;
	}
	int result = num1 % 10;
	Console.WriteLine(result);
} else {
	Console.WriteLine("Нет такой цыфры");
}
