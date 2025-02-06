using System;
using System.Formats.Asn1;

namespace DIKUCanteen
{
    class Program
    {
        static void Main(string[] args){

            Canteen myCanteen = new Canteen("DIKU Canteen");
            Student student1 = new Student("Frederik", "Student", 23);
            Student student2 = new Student("Marcus", "Student", 23);
            Student student3 = new Student("Jason", "Student", 23);
            CanteenBoardMember boardMember = new CanteenBoardMember("Åge", "Board Member", 25);

            Console.WriteLine(myCanteen);

            student1.TakeCup(myCanteen);
            student2.TakeCup(myCanteen);
            student3.TakeCup(myCanteen);
            student3.TakeCup(myCanteen);

            student1.ReturnCup(myCanteen);
            student2.TakeCup(myCanteen);
            student3.ReturnCup(myCanteen);

            boardMember.BuyCup(myCanteen);
            boardMember.BuyCup(myCanteen);

            Console.WriteLine(myCanteen);


        }
    }
}

