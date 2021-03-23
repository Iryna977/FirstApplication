using System;

namespace FirstApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserData();
        }

        static (string Name, string LastName, int Age, bool HasPet, int NumberPet, int NumberOfFavColors) UserData()
        {
            (string Name, string LastName, int Age, bool HasPet, int NumberPet, int NumberOfFavColors) User;
            Console.WriteLine("Введите Ваше имя:");
            User.Name = Console.ReadLine();
            Console.WriteLine("Введите Вашу фамилию:");
            User.LastName = Console.ReadLine();

            string strage;
            int intage;
            do
            {
                Console.WriteLine("Введите Ваш возраст:");
                strage = Console.ReadLine();
            }
            while (Check(strage, out intage));
            User.Age = intage;
            

           Console.WriteLine("У Вас есть питомец?");
            string pets = Console.ReadLine();
            if (pets == "Да")
            {
                User.HasPet = true;
                string numOfPets;
                int intNumOfPets;

                do
                {
                    Console.WriteLine("Сколько у Вас питомцев?");
                    numOfPets = Console.ReadLine();
                }                
                while( Check(numOfPets, out intNumOfPets));
                User.NumberPet = intNumOfPets;
                CreateArrayPets(intNumOfPets);
            }
            else
            {
                User.HasPet = false;
                User.NumberPet = 0;
            }
            string numFavCol;
            int intnumFavCol;
            do
            {
                Console.WriteLine("Сколько у Вас любимых цветов?");
                numFavCol = Console.ReadLine();
            }
            while (Check(numFavCol, out intnumFavCol));
            User.NumberOfFavColors = intnumFavCol;
            CreateArrayFavColors(intnumFavCol);
            return User;
        }
        static bool Check (string num, out int correctnum)
        {
            if (int.TryParse(num, out int intnum))
                if(intnum > 0)
            {
                    correctnum = intnum;
                    return false;
            }
                
                {
                   correctnum = 0;
                    return true;
                }
        }
        static string [] CreateArrayPets(int numpets)
        {
            var result = new string[numpets];
            for(int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Введите имя {i+1} питомца:");
                result[i] = Console.ReadLine();

            }
            return result;
        }
        static string[] CreateArrayFavColors(int numcol)
        {
            var result = new string[numcol];
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Введите {i+1} любимый цвет:");
                result[i] = Console.ReadLine();

            }
            return result;
        }


    }

}



