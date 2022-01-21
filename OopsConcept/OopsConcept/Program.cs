using System;
using OopsConcept.classobject;
using OopsConcept.Encapsulation;
using OopsConcept.Inheritance;
using OopsConcept.polymorphism.Methodoerloading;
using OopsConcept.polymorphism.MethodOverriding;
using OopsConcept.Abstraction;
using OopsConcept.Interface;
using OopsConcept.pass_by_value_and_reference;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Dog pug=new Dog();
             pug.age=10;
             pug.breed = "pug";
             pug.color = "black";
             pug.size = 23;
             pug.Sleep();
             Console.WriteLine("pug details:age;{0},size;{1},color:{2},breed:{3}", pug.age, pug.size, pug.color, pug.breed);

             Dog puppy = new Dog();
             puppy.age = 20;
             puppy.breed = "puppy";
             puppy.color = "white";
             puppy.size = 23;
             puppy.Sleep();
             Console.WriteLine("puppy details:age;{0},size;{1},color:{2},breed:{3}", puppy.age, puppy.size, puppy.color, puppy.breed);

             Dog moti = new Dog();
             moti.age = 30;
             moti.breed = "moti";
             moti.color = "";
             moti.size = 23;
             moti.Sleep();
             Console.WriteLine("moti details:age;{0},size;{1},color:{2},breed:{3}", moti.age, moti.size, moti.color, moti.breed);
            */

            /* Student prasad = new Student();
             prasad.name = "prasadc";
             prasad.subject ="history";
             prasad.marks = 100;
             prasad.rollno = 10;
             prasad.Sleep();
             Console.WriteLine("prasad details: name:{0},subject:{1},marks:{2},rollno:{3}",prasad.name,prasad.subject,prasad.marks,prasad.rollno);
             Student dipak = new Student();
             dipak.name = "dipakc";
             dipak.subject = "math";
             dipak.marks = 90;
             dipak.rollno = 20;
             dipak.Run();
             Console.WriteLine("dipak details: name:{0},subject:{1},marks:{2},rollno:{3}", dipak.name, dipak.subject, dipak.marks, dipak.rollno);
            */
            /* Accont ac = new Accont();
             ac.SetBalance(-1000);
             ac.GetBalance();
            */
            /* Rectangle r=new Rectangle();
              r.RectangleDetails();
              r.display();
            */
            /*Clar c = new Clar();
            c.Honk();
            c.Start();
            c.brand = "BMW";
            */
            /* Cow cow = new Cow();
             cow.Output();
             cow.Output1();
             Console.WriteLine("color:{0},size:{1}", cow.color, cow.size);
            
             /*Console.WriteLine("method overloading....");
             Addition add = new Addition();
             add.SumOfNumbers(10,20,30);
            */


            //PartTimeEmployee pt = new PartTimeEmployee();
            //pt.GetSalary();
            /*  Cfg ob = new Cfg();
              int sum2 = ob.Add(1, 2, 3);
              Console.WriteLine("sum of three" + "integer value", +sum2);
              double sum3=ob.Add(1.0,2.0,3.0);
              Console.WriteLine("sum of three" + "double value" + sum3);
            */
            /*Teacher1 t = new Teacher1();
            t.display();
            */
            /*  Lion l = new Lion();
              l.AnimalSound();
            */
            /* Pig p = new Pig();
             p.AnimalSound();
             p.Details();
            */
            /* FileInfo fi = new FileInfo();
             fi.ReadFile();
             fi.WriteFile();
            */
            // PassByValue.Test();
            PassByReference.TestReferenceType();
            Console.ReadLine();




        }
    }
}
