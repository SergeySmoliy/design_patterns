using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApplication34
{
    class children:mishen
    {

        Random rnd = new Random();

        public override void ochki_childres()
        {

            WriteLine("vistrel children");
            ochki_children = 198;
           
            int mishen = rnd.Next(40, 60);
            Console.WriteLine($"{mishen} mishen");



            int vistrel = rnd.Next(40, 60);
            Console.WriteLine($"{vistrel} pula");



            if (vistrel == mishen)
            {
                WriteLine("children popadaet v sel");
                WriteLine("Nachisleno ochkov\t" + ochki_children);
            }
            else
            {
                WriteLine("promah");
            }
        }

        public override void ochki_men()
        {
            
        }

        public override void ochki_Woman()
        {
            
        }
    }
}
