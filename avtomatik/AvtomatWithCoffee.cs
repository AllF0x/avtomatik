namespace avtomatik
{
    internal class AvtomatWithCoffee : AvtomatBase
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
                    water = 75,
                    milk = 0,
                    sugar = 0,
                    coffee = 75
                },
                new Coffee()
                {
                    nameNapitka = "капучино",
                    water = 10,
                    milk = 0,
                    sugar = 0,
                },
                new Coffee()
                {
                    nameNapitka = "латте",
                    water = 10,
                    milk = 0,
                    sugar = 0,
                }
            };
        }

        public void AvtomaticWork()
        {
            Console.WriteLine("Что вы хотите купить?(капучино, латте или американо)");
            string product = Convert.ToString(Console.ReadLine());
            if (product == "американо" || product == "Американо")
            {
                Console.WriteLine("Вы хотите сахар?(Да/Нет)");
                string otvetSugar1 = Convert.ToString(Console.ReadLine());
                if (otvetSugar1 == "Да" || otvetSugar1 == "да")
                {
                    Console.WriteLine("Вставте монетку и напишите её номенал");
                    int monetkaNomenal = Convert.ToInt32(Console.ReadLine());
                    int costAmericano = 160;
                    //За сахар надбавка 10 рублей
                    if (costAmericano <= monetkaNomenal)
                    {
                        double sdacha = costAmericano - monetkaNomenal;
                        Console.WriteLine($"Ваша сдача составила: {sdacha} рублей");
                    }
                    else
                    {
                        while (monetkaNomenal < costAmericano)
                        {
                            Console.WriteLine("Хей! У вас не хватает! Вставьте ещё монетку и напишите её номенал");
                            int newMonetkaNomenal = Convert.ToInt32(Console.ReadLine());
                            monetkaNomenal += newMonetkaNomenal;
                        }
                        double sdacha = costAmericano - monetkaNomenal;
                        Console.WriteLine($"Ваша сдача составила: {sdacha} рублей");
                    }
                }
                else if (otvetSugar1 == "Нет" || otvetSugar1 == "нет")
                {
                    Console.WriteLine("Вставте монетку и напишите её номенал");
                    int monetkaNomenal = Convert.ToInt32(Console.ReadLine());
                    int costAmericano = 150;
                    if (costAmericano <= monetkaNomenal)
                    {
                        double sdacha = costAmericano - monetkaNomenal;
                        Console.WriteLine($"Ваша сдача составила: {sdacha} рублей");
                    }
                    else
                    {
                        while (monetkaNomenal < costAmericano)
                        {
                            Console.WriteLine("Хей! У вас не хватает! Вставьте ещё монетку и напишите её номенал");
                            int newMonetkaNomenal = Convert.ToInt32(Console.ReadLine());
                            monetkaNomenal += newMonetkaNomenal;
                        }
                        double sdacha = costAmericano - monetkaNomenal;
                        Console.WriteLine($"Ваша сдача составила: {sdacha} рублей");
                    }
                }
            else if (product == "капучино" || product == "Капучино")
            {
                Console.WriteLine("Вы хотите сахар?(Да/Нет)");
                string otvetSugar2 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("А молоко?(Да/Нет)");
                string otvetMilk1 = Convert.ToString(Console.ReadLine());
                    if (otvetMilk1 == "Да" || otvetSugar2 == "Да" || otvetSugar2 == "да" && otvetMilk1 == "да")
                    {
                        Console.WriteLine("Вставте монетку и напишите её номенал");
                        int monetkaNomenal = Convert.ToInt32(Console.ReadLine());
                        int costCappuccino = 190;
                        //За молоко и сахар надбавка 20
                        if (costCappuccino <= monetkaNomenal)
                        {
                            double sdacha = costCappuccino - monetkaNomenal;
                            Console.WriteLine($"Ваша сдача составила: {sdacha} рублей");
                        }
                        else
                        {
                            while (monetkaNomenal < costCappuccino)
                            {
                                Console.WriteLine("Хей! У вас не хватает! Вставьте ещё монетку и напишите её номенал");
                                int newMonetkaNomenal = Convert.ToInt32(Console.ReadLine());
                                monetkaNomenal += newMonetkaNomenal;
                            }
                            double sdacha = costCappuccino - monetkaNomenal;
                            Console.WriteLine($"Ваша сдача составила: {sdacha} рублей");
                        }
                    }
                    else if (otvetSugar2 == "Нет" || otvetSugar2 == "нет")
                    {
                        Console.WriteLine("Вставте монетку и напишите её номенал");
                        int monetkaNomenal = Convert.ToInt32(Console.ReadLine());
                        int costCappuccino = 170;
                        if (costCappuccino <= monetkaNomenal)
                        {
                            double sdacha = costCappuccino - monetkaNomenal;
                            Console.WriteLine($"Ваша сдача составила: {sdacha} рублей");
                        }
                        else
                        {
                            while (monetkaNomenal < costCappuccino)
                            {
                                Console.WriteLine("Хей! У вас не хватает! Вставьте ещё монетку и напишите её номенал");
                                int newMonetkaNomenal = Convert.ToInt32(Console.ReadLine());
                                monetkaNomenal += newMonetkaNomenal;
                            }
                            double sdacha = costCappuccino - monetkaNomenal;
                            Console.WriteLine($"Ваша сдача составила: {sdacha} рублей");
                        }
                    }



                }
            }


        }
    }
}
