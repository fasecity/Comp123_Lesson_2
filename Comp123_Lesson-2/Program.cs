using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp123_Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUsrName();
        }
        /* This method reads user name  to console
         * @Method GetUrsName
         * @return {string} usrname
         * 
         * version 0.2 - Added UsrName
         
             */

        public static string GetUsrName()
        {
            Console.Write("Please enter user Name :");
            string usrname = "";
           usrname= Console.ReadLine();
            Console.WriteLine("_________");
            Console.WriteLine("you entered:" + usrname);
            return usrname;

        }
    }
}
