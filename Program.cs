using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Piotr","Kownacki",1994,2,10,"Siemanowice");
            student1.obliczWiek();
            student1.wypiszInfo();
            Osoba osoba1 = new Student("Pawel","Pawlowsi",1993,13,10,"Ketrzyn");
            osoba1.wypiszInfo();   // wypiszInfo przesloniete przez metode w klasie Osoba
            Osoba osoba2 = new Osoba();
            osoba1 = (Osoba)osoba2;
            osoba1.wypiszInfo();

            //Student student2 = new Osoba("Pawel", "pawel", 1994);  //Zabroniony zabieg

            StudentPierwszegoRoku studentpr1 = new StudentPierwszegoRoku();  // jednoczesnie dziedziczone metody, pola z dwoch klas 
            StudentPierwszegoRoku studentpr2 = new StudentPierwszegoRoku();
            Student student2 = new Student("Piotr", "Kownacki", 1994, 2, 10, "Siemanowice");
            student1 = (StudentPierwszegoRoku)studentpr1;
            student1.wypiszInfo();
            student1 = (Student)student2;
            student1.wypiszInfo();
            studentpr1.obliczWiek();

            Student student3 = new Student("Jaroslaw", "PolskeZbaw", 1993, 31, 23, "Katowice");
            Osoba osoba3 = new Osoba();
            osoba3 = (Student)student3;
            //student3 = (Osoba)osoba3; Zabieg zabroniony, chcemy aby student byl osoba
            osoba3.wypiszInfo();

            Student student4 = new Student();
            Osoba osoba4 = student4;      // Zabieg poprawny poniewaz rzutujemy osobe na studenta
            //Student studen5 = osoba4;  // Zabieg nie poprawny nie da rady rzutowac studenta na osobe
            student4.wypiszInfo();          // wzieto metode z klasy Student
            osoba4.wypiszInfo();           // wzieto metode z klasy Osoba
            Console.ReadKey();
        }
    }
}
