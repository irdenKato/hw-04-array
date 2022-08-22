Random rndm = new Random();

int value = rndm.Next(-20, 20); //Можно ли создать рандом sbyte?
int value1 = rndm.Next(-20, 20);
int value2 = rndm.Next(-20, 20);
int value3 = rndm.Next(-20, 20);
int value4 = rndm.Next(-20, 20);
int value5 = rndm.Next(-20, 20);
int value6 = rndm.Next(-20, 20);

int[] numbers = new int[] { value, value1, value2, value3, value4, value5, value6 };
var str = string.Join(" ", numbers);

Console.Write("Заданный массив:");
Console.WriteLine(str);

int temp; //сортировка по возрастанию
for (int i = 0; i < numbers.Length; i++) // выборка элемента с которым будем сравнивать
{
    for (int k = i+1; k < numbers.Length; k++) //выборка элементов следующих за i, кот-ые приводятся в сравнение
    {
        if (numbers[i] > numbers[k])
        {
            temp = numbers[i];
            numbers[i] = numbers[k];
            numbers[k] = temp;
        }
    }
}
var str2 = string.Join(" ", numbers);

Console.WriteLine("Вывод отсортированного по возрастанию массива:");
Console.WriteLine(str2);

int temp2; //сортировка по убыванию
for (int i = 0; i < numbers.Length; i++)
{
    for (int k = i + 1; k < numbers.Length; k++)
    {
        if (numbers[i] < numbers[k])
        {
            temp2 = numbers[i];
            numbers[i] = numbers[k];
            numbers[k] = temp2;
        }
    }
}

var str3 = string.Join(" ", numbers);

Console.WriteLine("Вывод отсортированного по убыванию массива:");
Console.WriteLine(str3);

