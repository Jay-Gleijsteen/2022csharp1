namespace Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i != 0; i++)
            {
                Console.WriteLine(DateTime.Now.ToString("H:mm:ss"));
                Thread.Sleep(1000);
                Console.Clear();
            }
        }  
    }
}
