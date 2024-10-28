namespace avtomatik
{
    internal class AvtomatSCoffee : AvtomatBASE
    {
        private double waterAmount;
        private double coffeeAmount;
        private double milkAmount;
        private double sugarAmount;

        public static List<Coffee> ListNapitkov()
        {
            return new List<Coffee>()
            {
                new Coffee()
                {
                    nameNapitka = "американо",
                    water = 10,
                    milk = 0,
                    sugar = 0,
                    stoimost = 150
                },
                new Coffee()
                {
                    nameNapitka = "капучино",
                    water = 10,
                    milk = 0,
                    sugar = 0,
                    stoimost = 170
                },
                new Coffee()
                {
                    nameNapitka = "латте",
                    water = 10,
                    milk = 0,
                    sugar = 0,
                    stoimost = 170
                }
            };
        }

        public woid AvtomaticWork()
        {
            Console.WriteLine("Что вы хотите купить?(капучино, латте или американо)");
            string product = Convert.ToString(Console.ReadLine());
            if (product == "американо" || product == "Американо")
            {
                Console.WriteLine("Вы хотите сахар?(Да/Нет)");
                string otvet = Convert.ToString(Console.ReadLine());
                if (otvet == "Да" || otvet == "да")
                {
                    Console.WriteLine("Вставте монетку и напишите её номенал");
                    int monetkaNomenal = Convert.ToInt32(Console.ReadLine());
                    ListNapitkov[0];
                    double sdacha = cash - monetkaNomenal;
                    Console.WriteLine($"Ваша сдача составила: {sdacha} рублей");
                }
                else if (otvet == "Нет" || otvet == "нет")
                {
                    Console.WriteLine("Вставте монетку и напишите её номенал");
                    int monetkaNomenal = Convert.ToInt32(Console.ReadLine());
                    double sdacha = cash - monetkaNomenal;
                    Console.WriteLine($"Ваша сдача составила: {sdacha} рублей");
                }
                //авлпоклаоьплапапапапа



            }
        }


    }
}
