using System;

namespace ArrangePersonel
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine(">ArrangePersonel.exe [SetPath] [InputPath] [OutputPath]");
                return;
            }
            Arrange a = new Arrange();
            a.SetPath = args[0];
            a.InputPath = args[1];
            a.OutputPath = args[2];
            a.Run();
        }
    }
}
