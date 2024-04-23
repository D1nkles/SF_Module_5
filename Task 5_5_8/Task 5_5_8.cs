class Task_5_5_8
{
    static int PowerUp(int N, byte pow)
{
        if (pow == 0) 
        {
            return 1;
        }
        else 
        {
            if (pow == 1) 
            {
                return N;
            }
            else 
            {
                return N * PowerUp(N, --pow);
            }
        }
}


    
    static void Main(string[] args) 
    {
        int a = PowerUp(2, 4);
    }
}