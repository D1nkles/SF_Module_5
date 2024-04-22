class Task_5_1_6 
{
    static int[] GetArrayFromConsole(int num = 5)
    {
        var result = new int[num];
        
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }
        return result;
    }
    static int[] Sort(int[] arr) 
    {
        int current = 0;
        for (int j = 0; j < arr.Length; j++)
        {
            for (int k = j; k < arr.Length; k++)
            {
                if (arr[j] > arr[k])
                {
                    current = arr[j];
                    arr[j] = arr[k];
                    arr[k] = current;
                }
            }
        }
        return arr;
    }
    static void Main() 
    {
        var array = GetArrayFromConsole(10);
        var sortedarray = Sort(array);
        foreach (var item in sortedarray) 
        {
            Console.Write(item + " ");
        }
    }
}