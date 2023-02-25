int[] array = { 10, 6, 8, 5, 3, 4, 10, 7, 6 };

int n = array.Length;
int find = 6;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}