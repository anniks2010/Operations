using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 2;

            //Arithmetic Operators
            //Multiple Line Comment alusesse /* ning lõppu */
            /*Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / y);*/

            //Console.WriteLine(x=y);
            //Console.WriteLine(x+=y);
            //Console.WriteLine(x -= y);
            //Console.WriteLine(x*=y);
            //Console.WriteLine(x % y); // jagunemise küsimus, kui jaguneb siis vastus =0 ning kui ei jagune, siis vastus=1

            //Comparison Operators
            /*Console.WriteLine(x == y);
            Console.WriteLine(x != y);
            Console.WriteLine(x > y);
            Console.WriteLine(x < y);
            Console.WriteLine(x >= y);
            Console.WriteLine(x <= y);*/
            
            

            //Logical operations
            //&& - AND
            // || - OR (Alt+Ctrl+>< klahv) see on pipes

            Console.WriteLine(x != y && y == 2);
            Console.WriteLine(x != y && y== 10 );
            Console.WriteLine(x != y || y == 2);
            Console.WriteLine(!(y == 10)); //topelt eitus on jaatus

            Console.ReadLine();
        }
    }
}
