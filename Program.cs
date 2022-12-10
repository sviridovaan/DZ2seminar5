//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях

Console.Clear();

Console.WriteLine("Введите число элементов массива");
int [] array = new int [Convert.ToInt32(Console.ReadLine())];
Random rnd = new Random();

int i = 0;
for (i = 0; i < array.Length; i++)
{
    array [i] = (rnd.Next (-10000, 10000));
}
Console.WriteLine($"Заданный массив: "+ '[' + string.Join(", ", array) + ']');

int sum = 0;
for (int index = 0; index < array.Length; index++)
{
    if (index % 2 == 0)
    {
        sum = sum + array[index];
    }
}
Console.WriteLine(sum);


