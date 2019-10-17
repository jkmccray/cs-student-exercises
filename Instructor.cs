namespace StudentExercises
{
    public class Instructor : NSSPerson
    {
        public string Specialty { get; set; }
        public void AssignStudentAnExercise(Student student, Exercise exercise) {
            student.ExerciseList.Add(exercise);
        }
    }
}