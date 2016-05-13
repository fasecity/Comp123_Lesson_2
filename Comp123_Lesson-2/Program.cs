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
 * version 0.5
 * added unit test
 * 0.6 refactored
 
         */

  public  class Program
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
           
            OutputstringToConsole("Enter user Name: ",false);
            usrname = Console.ReadLine();
            Console.WriteLine("\n==========");
            Console.WriteLine("you entered:" + usrname + "\n");
            return usrname;


        }
        /*
         * This method writes a string to the console.Parameters allow user to
         * choose to add new method
         * @
         */


        public static string OutputstringToConsole (string outputString, bool hasNewLine)
        {
            //if (hasNewLine)
            //{
            //    Console.WriteLine(outputString);
            //}
            //else
            //{
            //    Console.Write(outputString);
            //}
            string suffixstring = hasNewLine ? "\n" : "";
            Console.WriteLine(outputString+suffixstring);

            return outputString;
        }
    }
}
