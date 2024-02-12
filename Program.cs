using Kodlama_Io_WorkShop.Entities;
using System.Globalization;

namespace Kodlama_Io_WorkShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
              
            
            Trainer trainer1 = new Trainer(1,"Engin Demiroğ");
            Course kurs1 = new Course(1, "2024 Yazılım Gel.Kam.(c#)", 0, "Kurs", 0, trainer1);
            Console.WriteLine($"Course Name: {kurs1.CourseName}, " +
                $"Ucret : {kurs1.Price}, " +
                $"Completion Rate: {kurs1.Complete}," +
                $"eğitmen: {kurs1.Trainer.TrainerName}"
                );









        }
    }
}
