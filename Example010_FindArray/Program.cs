int[] array = { 1, 2, 3, 4, 6, 4, 97, 98, 94 };

int n = array.Length;
int find = 4;

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