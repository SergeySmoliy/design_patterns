using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApplication34
{
    public class Men : mishen
    {
        Random rnd = new Random();

        public override void ochki_childres()
        {
           
        }

        public override void ochki_men()
        {
            WriteLine("vistrel Man");

            ochki_Man = 95;
            int mishen = rnd.Next(70, 80);
            Console.WriteLine($"{mishen} mishen");


            int vistrel = rnd.Next(70, 80);
            Console.WriteLine($"{vistrel} pula");
            if (vistrel == mishen)
            {
                WriteLine("Woman popadaet v sel");
                WriteLine("Nachisleno ochkov\t" + ochki_Man);
            }
            else
            {
                WriteLine("promah");
            }
        }

        public override void ochki_Woman()
        {
           
        }
    }
}
