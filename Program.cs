
using System;

namespace oops
{
    // inheritance
    class A 
    {
        public string name = "obs";
        public void m1()
        {
            Console.WriteLine("m1 execute");
        }

    }

    class B : A
    {
        public string lastName = "vaddarapu"; 
    }

    class Program
    {
    public    static void Main(string[] args)
        {
            
         

             B obj = new B();

          
            obj.m1();
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();




            Pig1 myPig1 = new Pig1(); // Create a Pig object
            myPig1.animalSound2();  // Call the abstract method
            myPig1.sleep();  // 
            Console.WriteLine(obj.name);

            DemoEncap obj5 = new DemoEncap();//encapsulation method
                      
            obj5.Name = "obulesu";
           
            obj5.Age = 21;

         
            Console.WriteLine(" Name : " + obj5.Name);
            Console.WriteLine(" Age : " + obj5.Age);

            Pigs2 mg = new Pigs2();  // Create a Pigs2 object to the interface
            mg.animalSounds();

            DemoClass myObj = new DemoClass();
            myObj.myMethod();
            myObj.myOtherMethod();

            Class1 class1Instance = new Class1();
            class1Instance.AccessPrivateClassMethod();
           




            Console.WriteLine(obj.name + " " + obj.lastName);


            //control statemets

            controlstatements.Main11();
            controlstatements.Main1();
            controlstatements.Main2();
            controlstatements.Main4();
            controlstatements.Main5();
            controlstatements.Main6();

            controlstatements csd = new controlstatements();
            csd.m3();
            Hotel h = new Hotel();
            h.m3();
            simofers sf = new simofers();
            sf.Main32();
            busbooking bs = new busbooking();
            bs.M2();
            flight fl = new flight();
            fl.King();
            fl.BookTicket();
            fl.CancelTicket();
           fl.ViewBookedTickets();

            Phonepay pp = new Phonepay();
           pp.mm2();
            programsforinterview pi = new programsforinterview();
            pi.getall();



            Console.ReadLine();
        }
    }



}

