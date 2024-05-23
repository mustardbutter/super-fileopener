using System;
using System.Threading;

namespace FileRulette
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(@"              _______.
   ______    | .   . |\
  /     /\   |   .   |.\
 /  '  /  \  | .   . |.'|
/_____/. . \ |_______|.'|
\ . . \    /  \ ' .   \'|
 \ . . \  /    \____'__\|
  \_____\/");
            Console.SetCursorPosition(25, 6);
            Console.WriteLine("Rolling///");
            Thread.Sleep(1000);

            ProgrammStarter programmStarter = new ProgrammStarter();
            programmStarter.Run();
        }
    }
}
