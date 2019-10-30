using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using StudentExercises.Models;

namespace StudentExercises.Data
{
    class Repository
    {
        /// <summary>
        ///  Represents a connection to the database.
        ///   This is a "tunnel" to connect the application to the database.
        ///   All communication between the application and database passes through this connection.
        /// </summary>
        public SqlConnection Connection
        {
            get
            {
                // This is "address" of the database
                string _connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=StudentExercises;Integrated Security=True";
                return new SqlConnection(_connectionString);
            }
        }

        public List<Exercise> GetExercises()
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT Id, Name, Language FROM Exercises";
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Exercise> exercises = new List<Exercise>();
                    while (reader.Read())
                    {
                        // Use the reader's GetXXX methods to get the value for a particular ordinal.
                        int idValue = reader.GetInt32(reader.GetOrdinal("Id"));
                        string exerciseNameValue = reader.GetString(reader.GetOrdinal("Name"));
                        string exerciseLanguageValue = reader.GetString(reader.GetOrdinal("Language"));

                        // Create new exercise using the data from the database. Then add the exercise to the exercise list
                        Exercise exercise = new Exercise
                        {
                            Id = idValue,
                            Name = exerciseNameValue,
                            Language = exerciseLanguageValue
                        };
                        exercises.Add(exercise);
                    }
                    reader.Close();
                    return exercises;
                }
            }
        }

        public List<Exercise> GetExercisesForSpecificLanguage(string language)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT Id, Name, Language FROM Exercises WHERE Language = @language";
                    cmd.Parameters.Add(new SqlParameter("@language", language));


                    SqlDataReader reader = cmd.ExecuteReader();

                    List<Exercise> exercises = new List<Exercise>();
                    while (reader.Read())
                    {
                        // Use the reader's GetXXX methods to get the value for a particular ordinal.
                        int idValue = reader.GetInt32(reader.GetOrdinal("Id"));
                        string exerciseNameValue = reader.GetString(reader.GetOrdinal("Name"));
                        string exerciseLanguageValue = reader.GetString(reader.GetOrdinal("Language"));

                        // Create new exercise using the data from the database. Then add the exercise to the exercise list
                        Exercise exercise = new Exercise
                        {
                            Id = idValue,
                            Name = exerciseNameValue,
                            Language = exerciseLanguageValue
                        };
                        exercises.Add(exercise);
                    }
                    reader.Close();
                    return exercises;
                }
            }
        }

        public void AddNewExercise(Exercise exercise)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Exercises (Name, Language) Values (@name, @language)";
                    cmd.Parameters.Add(new SqlParameter("@name", exercise.Name));
                    cmd.Parameters.Add(new SqlParameter("@language", exercise.Language));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Instructor> GetInstructors()
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT i.Id, i.FirstName, I.LastName, i.Specialty, i.CohortId, c.Name FROM Instructors i INNER JOIN Cohorts c ON c.id = i.CohortId";
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Instructor> instructors = new List<Instructor>();
                    while (reader.Read())
                    {
                        // Use the reader's GetXXX methods to get the value for a particular ordinal.
                        int idValue = reader.GetInt32(reader.GetOrdinal("Id"));
                        string firstName = reader.GetString(reader.GetOrdinal("FirstName"));
                        string lastName = reader.GetString(reader.GetOrdinal("LastName"));
                        string specialty = reader.GetString(reader.GetOrdinal("Specialty"));
                        int cohortId= reader.GetInt32(reader.GetOrdinal("CohortId"));
                        string cohortName= reader.GetString(reader.GetOrdinal("Name"));

                        // Create new exercise using the data from the database. Then add the exercise to the exercise list
                        Instructor instructor = new Instructor
                        {
                            Id = idValue,
                            FirstName = firstName,
                            LastName = lastName,
                            Specialty = specialty,
                            Cohort = new Cohort
                            {
                                Id = cohortId,
                                Name = cohortName
                            }
                        };
                        instructors.Add(instructor);
                    }
                    reader.Close();
                    return instructors;
                }
            }
        }

        public void AddNewInstructor(Instructor instructor)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Instructors (FirstName, LastName, Specialty, SlackHandle, CohortId, Cohort) Values (@firstName, @lastName, @specialty, @slackHandle, @cohortId, @cohort)";
                    cmd.Parameters.Add(new SqlParameter("@firstName", instructor.FirstName));
                    cmd.Parameters.Add(new SqlParameter("@lastName", instructor.LastName));
                    cmd.Parameters.Add(new SqlParameter("@specialty", instructor.Specialty));
                    cmd.Parameters.Add(new SqlParameter("@slackHandle", instructor.SlackHandle));
                    cmd.Parameters.Add(new SqlParameter("@cohortId", instructor.CohortId));
                    cmd.Parameters.Add(new SqlParameter("@cohort", instructor.Cohort));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Cohort> GetCohorts()
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT Id, Name FROM Cohorts";

                    SqlDataReader reader = cmd.ExecuteReader();

                    List<Cohort> cohorts = new List<Cohort>();
                    while (reader.Read())
                    {
                        // Use the reader's GetXXX methods to get the value for a particular ordinal.
                        int idValue = reader.GetInt32(reader.GetOrdinal("Id"));
                        string cohortName = reader.GetString(reader.GetOrdinal("Name"));

                        // Create new exercise using the data from the database. Then add the exercise to the exercise list
                        Cohort cohort = new Cohort
                        {
                            Id = idValue,
                            Name = cohortName,
                        };
                        cohorts.Add(cohort);
                    }
                    reader.Close();
                    return cohorts;
                }
            }
        }
    }
}
