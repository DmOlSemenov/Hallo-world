int[] array = {19, 26, 31, 64, 519, 6, 71, 7, 29};
int n = array.Length;
int find = 71;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
        
    }
    //index = index + 1
    index++;
}

