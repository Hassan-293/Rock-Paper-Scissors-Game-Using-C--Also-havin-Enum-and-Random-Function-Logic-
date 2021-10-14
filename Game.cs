using System;
using System.Collections;

namespace _191159_Hassan_Raza
{

    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            ArrayList arrayList = new ArrayList();


            Console.WriteLine("Enter the name of the 2 Players:");
            for (int i = 0; i < 2; i++)
            {
                String a = Console.ReadLine();

                player.Name_Setter(a);
                player.Name_Getter();
                arrayList.Add(player.Name_Getter());

            }

            Console.WriteLine("Names of the players\n");
            Console.WriteLine("--------------------------------\n");

            foreach (var S in arrayList)
            {

                Console.WriteLine(S + " ");
            }
            Console.WriteLine("--------------------------------\n");
            for (int i = 0; i < 10; i++)
            {
                player.Action_Method();


                player.Match(arrayList);
            }


            Console.WriteLine("----------------------------------------------\n");
            Console.WriteLine("Result\n");
            //    Console.WriteLine(arrayList.Add(player.Name_Getter()));
            foreach (var S in arrayList)
            {

                Console.WriteLine(S + " ");
            }

            Console.WriteLine("No. of Wins of " + arrayList[0] + player.Wins_Getter());
            Console.WriteLine("No. of Loses " + arrayList[0] + player.Loses_Getter());


            Console.WriteLine("No. of Wins of " + arrayList[1] + player.Wins_Getter());
            Console.WriteLine("No. of Loses " + arrayList[1] + player.Loses_Getter());

            Console.WriteLine("----------------------------------------------\n");

            Console.ReadLine();





        }
    }

    public class Player
    {

        public string Name;
        public int Wins;
        public int Loses;

        public void Name_Setter(string Name)
        {
            this.Name = Name;

        }

        public void Wins_Setter(int Wins)
        {
            this.Wins = Wins;

        }
        public void Loses_Setter(int Loses)
        {
            this.Loses = Loses;

        }
        public string Name_Getter()
        {
            return Name;
        }
        public int Wins_Getter()
        {
            return Wins;
        }
        public int Loses_Getter()
        {
            return Loses;
        }


        public int Action_Method()
        {
            Random random = new Random();
            Array max = Enum.GetValues(typeof(Action));

            Action value = (Action)random.Next(max.Length);
            int X = Convert.ToInt32(value);
            //Console.WriteLine(X);

            return X;

        }
        public void Match(ArrayList arrayList)
        {





            int a, b;
            //     Action_Method() = a;
            a = Action_Method();
            b = Action_Method();
            Console.WriteLine(a + " " + b);

            if (a == 1 && b == 2)
            {
                Console.WriteLine(arrayList[0] + ":Rock\n");
                Console.WriteLine(arrayList[1] + ":Paper\n");
                Console.WriteLine(arrayList[1] + "has won");
                Wins++;
                Loses++;

            }

            else if (a == 1 && b == 3)
            {
                Console.WriteLine(arrayList[0] + ":Rock\n");
                Console.WriteLine(arrayList[1] + ":Scissors\n");
                Console.WriteLine(arrayList[0] + " has won");
                Wins++;
                Loses++;


            }

            else if (a == 2 && b == 3)
            {
                Console.WriteLine(arrayList[0] + ":Paper\n");
                Console.WriteLine(arrayList[1] + ":Scissors\n");

                Console.WriteLine(arrayList[1] + " has won");
                Wins++;
                Loses++;

            }



            else if (a == 2 && b == 1)
            {
                Console.WriteLine(arrayList[1] + ":Paper\n");
                Console.WriteLine(arrayList[0] + ":Rock\n");

                Console.WriteLine(arrayList[1] + " has won");
                Wins++;
                Loses++;

            }

            else if (a == 3 && b == 2)
            {
                Console.WriteLine(arrayList[0] + ":Scissors\n");
                Console.WriteLine(arrayList[1] + ":Paper\n");

                Console.WriteLine(arrayList[1] + " has won");
                Wins++;
                Loses++;

            }


            else if (a == 3 && b == 1)
            {
                Console.WriteLine(arrayList[0] + ": Rock\n");
                Console.WriteLine(arrayList[1] + ": Scissors\n");

                Console.WriteLine(arrayList[1] + " has won");
                Wins++;
                Loses++;   

            }

            if (arrayList[0] == arrayList[0] || arrayList[1] == arrayList[1])
            {
                Console.WriteLine("Same people cannot have a match");
            }



            else
                Console.WriteLine("Match is not played");


        }



    }

    public enum Action  
    {
        Rock,
        Paper,
        Scissors

    }


}
