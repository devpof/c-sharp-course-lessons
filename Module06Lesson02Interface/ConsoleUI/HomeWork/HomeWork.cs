using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class HomeWork
    {
        public static void Run()
        {
            List<IRun> runs = new List<IRun>();

            runs.Add(new Person());
            runs.Add(new Animal());

            foreach (IRun run in runs)
            {
                run.Walk();
                run.Run();
            }
        }
    }
}
