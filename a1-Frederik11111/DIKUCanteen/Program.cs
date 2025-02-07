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

            Console.WriteLine(myCanteen); //Expected: 100 cups available

            student1.TakeCup(myCanteen); //Expected: 99 cups left
            student2.TakeCup(myCanteen); //expected: 98 cups left
            student3.TakeCup(myCanteen); //expected: 97 cups left
            student3.TakeCup(myCanteen); //expected: jason already has a cup

            student1.ReturnCup(myCanteen); //Expected: 98 cups available
            student2.TakeCup(myCanteen);    //expected: Marcus already has a cup
            student3.ReturnCup(myCanteen); //Expected: 99 cups available

            boardMember.BuyCup(myCanteen); //expected: 100 cups now, budget left 49
            boardMember.BuyCup(myCanteen); //expected: 101 cups now, budget left 48

            Console.WriteLine(myCanteen); //expected 101 cups available in dikucanteen


        }
    }
}

