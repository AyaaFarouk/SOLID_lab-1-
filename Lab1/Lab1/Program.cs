namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegisterService reg = new RegisterService();
            reg.Register("Aya@gmail.com", "123");
        }
    }
}
