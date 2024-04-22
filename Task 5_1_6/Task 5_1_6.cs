class Task_5_1_6 
{
    static int[] GetArrayFromConsole()
    {
        var result = new int[5];
        int current = 0;
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }
        for (int j = 0; j < result.Length; j++) 
        {
            for (int k = j; k < result.Length; k++) 
            {
                if (result[j] > result[k]) 
                {
                    current = result[j];
                    result[j] = result[k];
                    result[k] = current;
                }
            }
        }
        return result;
    }
    static void Main() 
    {
        var arr = GetArrayFromConsole();
        foreach (var item in arr) 
        {
            Console.Write(item + " ");
        }
    }
}