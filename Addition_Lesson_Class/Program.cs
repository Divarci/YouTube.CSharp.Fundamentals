using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_Lesson_Class
{
    //Example test = new Example();

    //void method() { }

    internal class Program
    {

        Example test = new Example();

        void MethodInClass()
        {
            Example test3 = new Example();
            test3.Method();

            test.Method();
        }


        static void Main(string[] args)
        {
            Example test2 = new Example();
           
            test2.Method();
            
        }

        
    }

    class NewClass
    {

    }

    //namespace NewNamespace
    //{

    //}
}


public class Example
{
    public void Method () { }
}
