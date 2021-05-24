using lab1_restaurant.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_restaurant.IO
{
    public class InputConverter
    {
        public void readOrder(DateTime time,OutputService output, MenuExplorer menu)
        {
            Console.WriteLine("Choose dish number to order: ");
            string mesg = Console.ReadLine();
            try
            {
            int inpNum = msgParser(mesg, time,menu);
            //Console.WriteLine(inpNum);
            if (inpNum != 0)
            {
                output.order(inpNum,menu);
            }
            }catch(Exception)
            {
                Console.WriteLine("Wrong format");
            }
        }
        private int msgParser(string msg, DateTime time,MenuExplorer menu)
        {
            int num = int.Parse(msg);
            if (num > menu.getMenu(time).Count || num < 0)
            {
                throw new ArgumentException();
            }
            else { return num; }
        }
    }
}
