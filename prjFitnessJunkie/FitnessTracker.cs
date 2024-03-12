using prjFitnessApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFitnessJunkie
{
    internal class FitnessTracker
    {
      //arrayList that stores the custom exercises
            private List<Exercises> Workouts = new List<Exercises>();


            //This method populates the array with the user information
            public void PopulatedArray(Exercises ex)
            {
                Workouts.Add(ex);
            }

            public string PrintAll()
            {


                string strOutput = "";
                foreach (Exercises exercises in Workouts)
                {
                    strOutput += exercises.ToString();
                }


                return strOutput;

            }





        }
    }


