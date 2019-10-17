using System;

namespace ArrangePersonel
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine(">ArrangePersonel.exe [InputPath] [OutputPath]");
                return;
            }
            Arrange a = new Arrange();
            a.InputPath = args[0];
            a.OutputPath = args[1];
            a.Run();
        }
    }
}
