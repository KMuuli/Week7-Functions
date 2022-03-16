using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime;
            //programm küsib kasutajal sisestada numbrit 1-3;
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnime tagurpidi
            //kui kasutaja valid  '2', siis kuvatakse kasutaja eesnime esimest tähte
            //kui kasutaja valid '3' siis kuvatatakse kasutaja eesnime pikkust
            //funktsioone kutsutakse välja vastavalt kasutaja valikule

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta number 1 - 3");
            char userNumber = Convert.ToChar(Console.ReadLine());


            switch (userNumber)
            {
                case '1':
                GetUserNameBackwards(userName);
                    break;
                case '2':
                    GetUserNameFirstLetter(userName);
                    break;
                case '3':
                    GetUserNameLength(userName);
                    break;
                default:
                    break;
            }
            
        
        }

     



        public static void GetUserNameLength(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
        }

        public static void GetUserNameFirstLetter(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");
        }

        public static void GetUserNameBackwards(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }


    }
}
