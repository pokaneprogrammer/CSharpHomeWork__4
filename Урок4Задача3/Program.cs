// Напишите программу, которая задаёт массив из 8 элементов, выводит их на экран. 
// И ищет второй максимум (элемент меньше максимального, но больше всех остальных)
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33], 19

int[] mas = { 1, 2, 5, 7, 19, 6, 1, 33 };
void function(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}
function(mas);

int max = 0;
int secondmax = 0;
int[] arr = { 1, 2, 5, 7, 19, 6, 1, 33 };

for (int r = 0; r < arr.Length; r++)
{
    if (max < arr[r])
    {
        max = arr[r];
    }
}

for (int r = 0; r < arr.Length; r++)
{
    if (secondmax < arr[r] && arr[r] < max)
    {
        secondmax = arr[r];
    }
}

Console.WriteLine(secondmax);