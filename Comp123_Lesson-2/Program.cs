using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp123_Lesson_2
{
/**
 * This is the Driver program 
 * 
 * @Class Program
 * 
 * @Constructor Main
 * 
 * version 0.3
 
         */

    class Program
    {
        /** 
         Main Method for class Program
        @param string args
            @constructor Main
         
             
            **/

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
