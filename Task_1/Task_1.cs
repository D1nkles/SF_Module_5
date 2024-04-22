
class Task_1 
{
    static void Main(string[] args) 
    {
        (string Name, string[] Dishes)User;

        Console.Write("Введите имя пользователя: ");
        User.Name = Console.ReadLine();

        User.Dishes = new string[5];
        Console.WriteLine("Введите пять ваших любимых блюд...");
        for (int i = 0; i < User.Dishes.Length; i++) 
        {
            Console.Write($"Любимое блюдо №{i + 1}: ");
            User.Dishes[i] = Console.ReadLine();
        }
    }
}