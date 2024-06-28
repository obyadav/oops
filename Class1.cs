using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    
        class Class1
        {
            private class abcd
            {
                // Private method ob, accessible only within the abcd class
                void ob()
                {
                    Console.WriteLine("ob method executed in PRIVATE CLASS");
                }

                // Public method m2, can be accessed within Class1
                public void m2()
                {
                    abcd AA = new abcd();
                    AA.ob();
                }
            }



            // Method to create an instance of the private abcd class and call its m2 method
            public void AccessPrivateClassMethod()
            {
                abcd instance = new abcd();
                instance.m2();
            }
        }

      
    }


