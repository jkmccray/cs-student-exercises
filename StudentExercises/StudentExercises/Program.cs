using System;
using System.Collections.Generic;
using StudentExercises.Data;
using StudentExercises.Models;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new Repository();

            // i. Query the database for all the Exercises.
            List<Exercise> exercises = repository.GetExercises();
            Console.WriteLine("All Exercises");
            foreach (Exercise e in exercises)
            {
                Console.WriteLine($"{e.Name}: {e.Language}");
            }
            Console.ReadLine();

            // ii. Find all the exercises in the database where the language is JavaScript.
            List<Exercise> exercisesInJavaScript = repository.GetExercisesForSpecificLanguage("JavaScript");
            Console.WriteLine("JavaScript Exercises");
            foreach (Exercise e in exercisesInJavaScript)
            {
                Console.WriteLine($"{e.Name}: {e.Language}");
            }
            Console.ReadLine();

            // iii. Insert a new exercise into the database.
            Exercise newExercise = new Exercise
            {
                Name = "Student Exercises",
                Language = "C#"
            };
            //repository.AddNewExercise(newExercise);

            List<Exercise> updatedExercises = repository.GetExercises();
            Console.WriteLine("All Exercises After Adding New Exercise");
            foreach (Exercise e in updatedExercises)
            {
                Console.WriteLine($"{e.Name}: {e.Language}");
            }
            Console.ReadLine();

            // iv. Find all instructors in the database. Include each instructor's cohort.
            List<Instructor> instructors = repository.GetInstructors();
            Console.WriteLine("All Instructors");
            foreach (Instructor i in instructors)
            {
                Console.WriteLine($"{i.Cohort.Name}: {i.FirstName} {i.LastName}, {i.Specialty}");
            }
            Console.ReadLine();

            // v. Insert a new instructor into the database. Assign the instructor to an existing cohort.
            
        }
    }
}
