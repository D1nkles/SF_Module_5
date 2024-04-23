class Task_5_3_13 
{
    static int[] SortArrayAsc(int[] array) 
    {
        int[] sortedarray = new int[array.Length];
        int current = 0;
        for (int j = 0; j < array.Length; j++)
        {
            for (int k = j; k < array.Length; k++)
            {
                if (array[j] > array[k])
                {
                    current = array[j];
                    array[j] = array[k];
                    array[k] = current;
                }
            }
        }

        for (int i = 0; i < array.Length; i++) 
        {
            sortedarray[i] = array[i];
        }
        return sortedarray;
    }
    static int[] SortArrayDesc(int[] array)
    {
        int[] sortedarray = new int[array.Length];
        int current = 0;
        for (int j = 0; j < array.Length; j++)
        {
            for (int k = j; k < array.Length; k++)
            {
                if (array[j] < array[k])
                {
                    current = array[j];
                    array[j] = array[k];
                    array[k] = current;
                }
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            sortedarray[i] = array[i];
        }
        return sortedarray;
    }
    static void SortArray(int[] array, out int[] sorteddesc, out int[] sortedasc) 
    {
        sortedasc = SortArrayAsc(array);
        sorteddesc = SortArrayDesc(array);
    }
    static void Main(string[] args) 
    {
        int[] array = {-5, 2, 254, 85, -26, 75, -2 };
        int[] sorteddesc;
        int[] sortedasc;
        SortArray(array, out sorteddesc, out sortedasc);

        Console.Write("Вывод сортировки эл-ов по убыванию: ");
        foreach (var num in sorteddesc) 
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        Console.Write("Вывод сортировки эл-ов по возрастанию: ");
        foreach (var num in sortedasc)
        {
            Console.Write(num + " ");
        }
    }
}