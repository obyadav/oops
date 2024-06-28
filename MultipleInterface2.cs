using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
   
    interface IMultipleInterface2
    {
        void myMethod(); // interface method
    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method
    }

    // Implement multiple interfaces
    class DemoClass : IMultipleInterface2, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("my method is executed.");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("my other method is executed");
        }
    }

  

}
