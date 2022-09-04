
Console.WriteLine("Ввeдите количество цифр с случайном масиве ");
int A=Convert.ToInt32(Console.ReadLine());
int[] numbers = new int [A];
FillArray(numbers);
PrintArray(numbers);
void FillArray(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next();
}
}

void PrintArray(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
}