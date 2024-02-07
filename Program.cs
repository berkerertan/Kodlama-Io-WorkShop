using Kodlama_Io_WorkShop.Entities;
using System.Globalization;

namespace Kodlama_Io_WorkShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
              
            //Course course1 = new Course(1,"2024 Yazılım Gel.Kam.(c#)",0,"Kurs",0,"Engin Demiroğ");
            //Course course2 = new Course(2, "2023 Python & Selenium Kamp", 14, "Testing", 0,"Halit Enes Kalaycı");
            //Course course3 = new Course(3, "Yaz.Gel. JavaScript", 50, "1.5 Ay sürecek...", 0, "Engin Demiroğ");
            //Course course4 = new Course(4, "JAVA + REACT Yaz. Gel. Kamp.", 0, "2 Ay Sürecek...", 0, "Engin Demiroğ");
            //Course course5 = new Course(5, "C#+Anglar Yaz. Gel. Kam.", 0, null, 0, "Engin Demiroğ");

            //Console.WriteLine($"Course Name: {course1.CourseName}, Completion Rate: {course1.Complete},{course1.Trainer}");
            //Console.WriteLine($"Course Name: {course2.CourseName}, Completion Rate: {course2.Complete},{course2.Trainer}");
            //Console.WriteLine($"Course Name: {course3.CourseName}, Completion Rate: {course3.Complete},{course3.Trainer}");
            //Console.WriteLine($"Course Name: {course4.CourseName}, Completion Rate: {course4.Complete},{course4.Trainer}");
            //Console.WriteLine($"Course Name: {course5.CourseName}, Completion Rate: {course5.Complete},{course5.Trainer}");


            Trainer trainer1 = new Trainer(1,"Engin Demiroğ");
            Category category1 = new Category(1, "Programlama");
            Course kurs1 = new Course(1, "2024 Yazılım Gel.Kam.(c#)", 0, "Kurs", 0, trainer1);
            Console.WriteLine($"Course Name: {kurs1.CourseName}, Ucret : {kurs1.Price}, Completion Rate: {kurs1.Complete},{kurs1.Trainer}");









        }
    }
}
