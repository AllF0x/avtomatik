using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace avtomatik
{
    internal class Avtomat
    {
        public string name;
        public int cash { get; private set; }
        public double water { get; private set; }
        public double coffee { get; private set; }
        public double milk { get; private set; }
        public double sugar { get; private set; }
        public int amountSales { get; private set; }


        public woid AvtomaticWork()
        {
            Console.WriteLine("Что вы хотите купить?(капучино, латте или американо)");
            string product = Convert.ToString(Console.ReadLine());
            if (product == "американо" || product == "Американо")
            {
                Console.WriteLine("Вы хотите сахар?(Да/Нет)");
                string otvet = Convert.ToString(Console.ReadLine());
                if (otvet == "Да" ||  otvet == "да")
                {
                    Console.WriteLine("Вставте монетку и напишите её номенал");
                    int monetkaNomenal = Convert.ToInt32(Console.ReadLine());
                    double sdacha = cash - monetkaNomenal;
                    Console.WriteLine($"Ваша сдача составила: {sdacha} рублей");
                }
                else if(otvet == "Нет" || otvet == "нет")
                {

                }
                
                     
                
            }
        }
        

    }
}
