namespace StudentExercises
{
    public class Instructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public string Specialty { get; set; }
        public void AssignStudentAnExercise(Student student, Exercise exercise) {
            student.ExerciseList.Add(exercise);
        }
    }
}