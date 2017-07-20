using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmlDotNetSandardClass;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DotNetStandardClass failingClass = new DotNetStandardClass();
            try
            {
                failingClass.MethodDoesNotFail();
                Console.WriteLine("The Good method ran");

                failingClass.MethodThatFails();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message + Environment.NewLine + ex.StackTrace + Environment.NewLine + ex.InnerException);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
