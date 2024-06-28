using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
  
        // Abstract class
        abstract class Animal1
        {
            // Abstract method (does not have a body)
            public abstract void animalSound2();

            // Regular method
            public void sleep()
            {
                Console.WriteLine("Zzz");
            }
        }

        // Derived class (inherit from Animal)
        class Pig1 : Animal1
        {
            public override void animalSound2()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("The pig says: wee wee");
            }
        }

       












    
}
