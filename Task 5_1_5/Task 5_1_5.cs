class Task_5_1_5 
{
    static string ShowColor() 
    {
        string color;
        Console.Write("Введите ваш любимый цвет: ");
        color = Console.ReadLine();
        return color;
    }
    static void Main(string[] args) 
    {
        var favcolors = new string[3];
        for (int i = 0; i < favcolors.Length; i++) 
        {
            favcolors[i] = ShowColor();
        }
        Console.WriteLine("====================================================");
        foreach (var color in favcolors) 
        {
            Console.WriteLine(color);
        }
    }
}