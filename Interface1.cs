using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
  
        // Interface
        interface Interface1
        {
            void animalSounds(); // interface method (does not have a body)
        }

        // Pig "implements" the IAnimal interface
        class Pigs2 : Interface1
    {
            public void animalSounds()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("interface method is executed");
            }
        }

      
}
