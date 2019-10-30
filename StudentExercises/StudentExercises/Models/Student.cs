using System.Collections.Generic;

namespace StudentExercises.Models
{
    public class Student : NSSPerson
    {
        public List<Exercise> ExerciseList = new List<Exercise>();
    }
}