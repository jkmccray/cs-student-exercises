using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise ChickenMonkey = new Exercise();
            ChickenMonkey.Name = "ChickenMonkey";
            ChickenMonkey.Language = "JavaScript";

            Exercise FavoriteThings = new Exercise();
            FavoriteThings.Name = "Favorite Things";
            FavoriteThings.Language = "JavaScript";

            Exercise Kennel = new Exercise();
            Kennel.Name = "Kennel";
            Kennel.Language = "React";

            Exercise CssSelectors = new Exercise();
            CssSelectors.Name = "CSS Selectors";
            CssSelectors.Language = "CSS";

            Cohort c33 = new Cohort();
            c33.Name = "Cohort 33";

            Cohort c34 = new Cohort();
            c34.Name = "Cohort 34";

            Cohort c35 = new Cohort();
            c35.Name = "Cohort 35";

            Student student1 = new Student();
            student1.FirstName = "Harry";
            student1.LastName = "Potter";
            student1.SlackHandle = "TheQuiddichBitch";
            student1.Cohort = c33;

            Student student2 = new Student();
            student2.FirstName = "Ron";
            student2.LastName = "Weasley";
            student2.SlackHandle = "SlugMan";
            student2.Cohort = c34;

            Student student3 = new Student();
            student3.FirstName = "Hermione";
            student3.LastName = "Granger";
            student3.SlackHandle = "ThatPunchFeltGood";
            student3.Cohort = c35;

            Student student4 = new Student();
            student4.FirstName = "Draco";
            student4.LastName = "Malfoy";
            student4.SlackHandle = "MyFatherWillHearAboutThis";
            student4.Cohort = c33;

            Instructor instructor1 = new Instructor();
            instructor1.FirstName = "Severus";
            instructor1.LastName = "Snape";
            instructor1.SlackHandle = "TheHalfBloodPrince";
            instructor1.Specialty = "Potions";
            instructor1.Cohort = c34;

            Instructor instructor2 = new Instructor();
            instructor2.FirstName = "Filius";
            instructor2.LastName = "Flitwick";
            instructor2.SlackHandle = "OneCharmingDude";
            instructor2.Specialty = "Charms";
            instructor2.Cohort = c33;

            Instructor instructor3 = new Instructor();
            instructor3.FirstName = "Minerva";
            instructor3.LastName = "McGonagall";
            instructor3.SlackHandle = "ShouldITurnYouIntoAPocketwatch";
            instructor3.Specialty = "Transfiguration";
            instructor3.Cohort = c35;

            instructor1.AssignStudentAnExercise(student1, ChickenMonkey);
            instructor2.AssignStudentAnExercise(student1, CssSelectors);
            instructor1.AssignStudentAnExercise(student2, Kennel);
            instructor3.AssignStudentAnExercise(student2, ChickenMonkey);
            instructor2.AssignStudentAnExercise(student3, CssSelectors);
            instructor3.AssignStudentAnExercise(student3, FavoriteThings);
            instructor1.AssignStudentAnExercise(student4, Kennel);
            instructor3.AssignStudentAnExercise(student4, FavoriteThings);

            List<Student> allStudents = new List<Student>() {
                student1, student2, student3, student4
            };

            List<Exercise> allExercises = new List<Exercise>() {
                ChickenMonkey, CssSelectors, Kennel, FavoriteThings
            };

            foreach (Exercise exercise in allExercises)
            {
                Console.WriteLine($"Students Working on {exercise.Name}:");
                foreach (Student student in allStudents)
                {
                    if (student.ExerciseList.Exists(studentExercise => exercise == studentExercise))
                    {
                        Console.WriteLine($"{student.FirstName} {student.LastName}");
                    }
                }
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}
