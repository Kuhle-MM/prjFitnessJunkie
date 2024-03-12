using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace prjFitnessApplication
    {
        public class Exercises

        // 30 min = 300 // Need a matrix for estimation for calerios/time = per sec example // a research base matric // input bmi // with the bmi if statments to get a general calerory count  
        {
            //Constructor ? I dont know if we will need it but we should discuss  


            //Creating Exercises
            //this one is for and exercise that doesnt have distance and only needs duration to work out the calories

            /*sites say we should use MET to calc calories and idk how to calculate that but there are certain average 
            METs so we can hard code it.*/
            private double duration;
            private double distance;
            private string name;

            private double weight;
            private double height;
            private double CalBurnt;



            public Exercises(String name, double duration, double weight, double height)
            {
                //i.e.  this.name = name;
                this.name = name;
                this.duration = duration;
                this.weight = weight;
                this.height = height;

                CalorieCalculation(duration, this.Weight, this.Height);
            }

            //This one is for exercises that need distance to workout the calories
            public Exercises(String name, double duration, double weight, double height, double distance)
            {
                //i.e.  this.name = name;
                this.name = name;
                this.duration = duration;
                this.distance = distance;
                this.weight = weight;
                this.height = height;

                CalorieCalculation(duration, weight, height);

            }

            public double Height { get => height; set => height = value; }
            public double Weight { get => weight; set => weight = value; }

            public double CalorieCalculation(double duration, double weight, double height)
            {
                double CalBurnt;
                double calSmall = 1200;
                int calMedium = 1800;
                int calLarge = 2000;

                double BMI = Weight / (Height * Height);


                if (BMI == 20 && BMI > 29)
                {
                    CalBurnt = calSmall / duration;
                }
                else if (BMI == 30 && BMI > 39)
                {
                    CalBurnt = calMedium / duration;
                }
                else
                {
                    CalBurnt = calLarge / duration;

                }

                this.Weight = weight;
                this.Height = height;
                this.duration = duration;

                return CalBurnt;
            }

            public override string ToString()
            {
            
                return "\nExercise name:\t\t" + name + "\nTime:\t\t\t" + duration + "mins  \nDistance:\t\t" + distance + "Km \nCalories burned:\t" + CalorieCalculation(this.duration, this.Weight, this.Height) + "Kcal\n";
            }
        }
    }



