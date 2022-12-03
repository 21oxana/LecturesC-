// задача на нахождения индекса заданного элемента в массиве

int[] array = { 1, 12, 31, 4, 18, 15, 16, 17, 18 };

int n = array.Length; //возвращает длину элементов массива
int find = 18;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // нужно для нахождения только первого элемента, чтобы не все выгружалось в терминал
    }
    index++;
}