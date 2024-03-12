using prjFitnessApplication;

namespace prjFitnessJunkie 
{
    internal static class Program 
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static double durationInSec = 0;
        public static bool quit = false;
        public static double weight;
        public static double height;
        public static string strNo = "Yes";
        public static FitnessTracker ea = new FitnessTracker();

        [STAThread]
        static void Main() 
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            
            static void Main(string[] args) 
            {
                //Console.WriteLine("Welcome to FitnessJunkie tracker App"); --Kuhle 
                //Console.WriteLine("******************"); --Kuhle

                InputInformation();

                while (quit == false)
                {
                    menu1();

                }

            }

            public static void menu1()
            {

                Console.WriteLine("\n MAIN MENU");
                Console.WriteLine("===============");
                Console.WriteLine("Please select what you want to do");
                Console.WriteLine("Enter 1 to select a Pre-set workout  (1) ");
                Console.WriteLine("Enter 2 to display workouts (2) ");
                Console.WriteLine("Enter 3 to Quit (3) ");
                String userInput = Console.ReadLine();

                strNo = "yes";
                if (userInput.Equals("1"))
                {
                    while (!strNo.Equals("no", StringComparison.OrdinalIgnoreCase))
                    {
                        AddExercise();
                    }


                }
                else if (userInput.Equals("2"))
                {

                    Console.WriteLine("\n" + ea.PrintAll());
                }
                else if (userInput.Equals("3"))
                {
                    quit = true;
                }

            }

            public static string exerciseList()
            {
                string workoutName = "No name";
                Console.WriteLine("\nPlease enter the number of the type of exercise you would like: ");
                Console.WriteLine("1. Running\n2. Swimming\n3. Cycling\n4. Circuits");
                String exInputNumber = Console.ReadLine();
                Console.WriteLine("");
                bool flag = false;

                while (flag == false)
                {
                    if (exInputNumber == "1")
                    {
                        workoutName = "Running";
                        flag = true;
                    }
                    else if (exInputNumber == "2")
                    {
                        workoutName = "Swimming";
                        flag = true;
                    }
                    else if (exInputNumber == "3")
                    {
                        workoutName = "Cycling";
                        flag = true;
                    }
                    else if (exInputNumber == "4")
                    {
                        workoutName = "Circuits";
                        flag = true;
                    }
                    else
                    {
                        Console.Write("Invalid input. Please select a number from the list above:");
                        exInputNumber = Console.ReadLine();
                        flag = false;
                    }
                }
                return workoutName;
            }

            public static void/*subject to change*/ AddExercise()
            {


                string workoutName = exerciseList();
                Console.WriteLine(workoutName);

                Console.WriteLine("Enter the mins for your exercise: ");
                string min = Console.ReadLine();
                Console.WriteLine("Enter the seconds for your exercise: ");
                string sec = Console.ReadLine();
                Console.WriteLine("Enter the distance for your exercise: ");
                string dist = Console.ReadLine();

                durationInSec = calculateDurationInMinutes(sec, min);

                ea.PopulatedArray(new Exercises(workoutName, durationInSec, weight, height, Convert.ToDouble(dist)));
                // Console.WriteLine( "\n" + ea.PrintAll());


                Console.WriteLine("would you like to add more? Yes or No");
                strNo = Console.ReadLine();
                Console.WriteLine("");
            }

            private static double calculateDurationInMinutes(string sec, string min)
            {


                double duration = (Convert.ToDouble(sec) / 60) + Convert.ToDouble(min);

                return duration;
            }

            /*public static Exercises customExercise()
            {
                //user inputs
                Console.WriteLine("Enter the name of your exercise");
                String workoutName = Console.ReadLine();

                double duration = calculateDurationInSeconds();

                Console.WriteLine("Do you need to add distance(Y or N");
                string distCheck = "!!!";

                while (distCheck!="Y"|| distCheck!="N")
                {
                    distCheck = Console.ReadLine();

                    bool boolDistance ;
                    if (distCheck == "Y")
                    {
                        boolDistance = true;
                        distCheck = "!!!";
                    }
                    else if (distCheck == "N")
                    {
                        boolDistance = false;
                        distCheck= "!!!";
                    }
                    else
                    {
                        Console.WriteLine("re-enter your answer");
                        Console.WriteLine("Do you need to add distance(Y or N");
                        distCheck = Console.ReadLine();
                    }

                }
                int distance;
                Exercises newExercise = null;
                if (distCheck == "Y")
                {
                    Console.WriteLine("How far did you travel in metres?: "); //convert to metres in calculation
                    distance = Convert.ToInt32(Console.ReadLine());

                    newExercise = new Exercises(workoutName, duration, distance);
                }
                else if (distCheck == "N")
                {
                    newExercise = new Exercises(workoutName, duration);
                }

                return newExercise;
            }
            */

            public static void InputInformation()
            {
                Console.WriteLine("Enter your Name");
                Console.ReadLine();

                Console.WriteLine("Enter Surname");
                Console.ReadLine();

                Console.WriteLine("Enter your weight in Kg");
                weight = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your height in metres");
                height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");

            }
        }
    }


}