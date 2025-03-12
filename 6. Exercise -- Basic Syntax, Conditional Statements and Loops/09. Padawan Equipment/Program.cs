using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int studentsNumber = int.Parse(Console.ReadLine());
            decimal saberPrice = decimal.Parse(Console.ReadLine());
            decimal robePrice = decimal.Parse(Console.ReadLine());
            decimal beltPrice = decimal.Parse(Console.ReadLine());
            int freeBelts = studentsNumber / 6;
            decimal equipmentCost = saberPrice * (studentsNumber + (Math.Ceiling(studentsNumber * 0.10m))) + robePrice * studentsNumber + (beltPrice * studentsNumber - (beltPrice * freeBelts));


            if (equipmentCost <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {equipmentCost:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {equipmentCost - money:f2}lv more.");
            }
                
        }
    }
}
