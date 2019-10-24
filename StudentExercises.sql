-- 1. Create tables for each entity. These should match the dbdiagram ERD you created in Student Exercises Part 1.

--CREATE TABLE Cohorts (
--    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
--    Name VARCHAR(55) NOT NULL
--);

  
--CREATE TABLE Exercises (
--    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
--    Name VARCHAR(55) NOT NULL,
--    Language VARCHAR(55) NOT NULL
--);

--CREATE TABLE Students (
--    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
--    FirstName VARCHAR(55) NOT NULL,
--    LastName VARCHAR(55) NOT NULL,
--    SlackHandle VARCHAR(55) NOT NULL,
--    CohortId INTEGER NOT NULL,
--    CONSTRAINT FK_Student_Cohort FOREIGN KEY(CohortId) REFERENCES Cohorts(Id)
--);

--CREATE TABLE Instructors (
--    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
--    FirstName VARCHAR(55) NOT NULL,
--    LastName VARCHAR(55) NOT NULL,
--    SlackHandle VARCHAR(55) NOT NULL,
--    Specialty VARCHAR(55) NOT NULL,
--    CohortId INTEGER NOT NULL,
--    CONSTRAINT FK_Instructor_Cohort FOREIGN KEY(CohortId) REFERENCES Cohorts(Id)
--);

--CREATE TABLE StudentExercises (
--    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
--    StudentId INTEGER NOT NULL,
--    ExerciseId INTEGER NOT NULL,
--    CONSTRAINT FK_Assigned_Student FOREIGN KEY(StudentId) REFERENCES Students(Id),
--    CONSTRAINT FK_Assigned_Exercise FOREIGN KEY(ExerciseId) REFERENCES Exercises(Id)
--);

-- 2. Populate each table with data. You should have 2-3 cohorts, 5-10 students, 4-8 instructors, 2-5 exercises and each student should be assigned 1-2 exercises.

--INSERT INTO Exercises (Name, Language) VALUES ('ChickenMonkey', 'JavaScript')
--INSERT INTO Exercises (Name, Language) VALUES ('Favorite Things', 'JavaScript')
--INSERT INTO Exercises (Name, Language) VALUES ('Kennel', 'React')
--INSERT INTO Exercises (Name, Language) VALUES ('CSS Selectors', 'CSS')
--INSERT INTO Cohorts (Name) VALUES ('Cohort 33')
--INSERT INTO Cohorts (Name) VALUES ('Cohort 34')
--INSERT INTO Cohorts (Name) VALUES ('Cohort 35')
--INSERT INTO Students (FirstName, LastName, SlackHandle, CohortId) VALUES ('Harry', 'Potter', 'TheQuiddichBitch', 1)
--INSERT INTO Students (FirstName, LastName, SlackHandle, CohortId) VALUES ('Ron', 'Weasley', 'SlugMan', 2)
--INSERT INTO Students (FirstName, LastName, SlackHandle, CohortId) VALUES ('Hermione', 'Granger', 'ThatPunchFeltGood', 3)
--INSERT INTO Students (FirstName, LastName, SlackHandle, CohortId) VALUES ('Draco', 'Malfoy', 'MyFatherWillHearAboutThis', 3)
--INSERT INTO Students (FirstName, LastName, SlackHandle, CohortId) VALUES ('Neville', 'Longbottom', 'ILongForYourBottom', 2)
--INSERT INTO Instructors(FirstName, LastName, SlackHandle, Specialty, CohortId) VALUES ('Severus', 'Snape', 'TheHalfBloodPrince', 'Potions', 3)
--INSERT INTO Instructors(FirstName, LastName, SlackHandle, Specialty, CohortId) VALUES ('Filius', 'Flitwick', 'OneCharmingDude', 'Charms', 1)
--INSERT INTO Instructors(FirstName, LastName, SlackHandle, Specialty, CohortId) VALUES ('Minerva', 'McGonagall', 'ShouldITurnYouIntoAPocketwatch', 'Transfiguration', 2)
--INSERT INTO Instructors(FirstName, LastName, SlackHandle, Specialty, CohortId) VALUES ('Gilderoy', 'Lockhart', 'AnInternationallyFamousWizard', 'Defense Against The Dark Arts', 1)
--INSERT INTO StudentExercises (StudentId, ExerciseId) VALUES (1, 1)
--INSERT INTO StudentExercises (StudentId, ExerciseId) VALUES (1, 2)
--INSERT INTO StudentExercises (StudentId, ExerciseId) VALUES (2, 1)
--INSERT INTO StudentExercises (StudentId, ExerciseId) VALUES (2, 3)
--INSERT INTO StudentExercises (StudentId, ExerciseId) VALUES (3, 2)
--INSERT INTO StudentExercises (StudentId, ExerciseId) VALUES (3, 3)
--INSERT INTO StudentExercises (StudentId, ExerciseId) VALUES (4, 3)
--INSERT INTO StudentExercises (StudentId, ExerciseId) VALUES (4, 4)
--INSERT INTO StudentExercises (StudentId, ExerciseId) VALUES (5, 4)
--INSERT INTO StudentExercises (StudentId, ExerciseId) VALUES (5, 2)


-- 3. Write a query to return all student first and last names with their cohort's name.

--SELECT s.FirstName,
--       s.LastName,
--	   c.Name
--FROM Students s
--	LEFT JOIN Cohorts c on s.CohortId = c.Id
--;

-- 4. Write a query to return student first and last names with their cohort's name only for a single cohort.

--SELECT s.FirstName,
--       s.LastName,
--	   c.Name
--FROM Students s
--	LEFT JOIN Cohorts c on s.CohortId = c.Id
--WHERE c.Id = 3
--;

-- 5. Write a query to return all instructors ordered by their last name.
--SELECT FirstName,
--	   LastName
--FROM Instructors
--ORDER BY LastName 
--;

-- 6. Write a query to return a list of unique instructor specialties.
--SELECT DISTINCT Specialty
--FROM Instructors
--;

-- 7. Write a query to return a list of all student names along with the names of the exercises they have been assigned. If an exercise has not been assigned, it should not be in the result.
--SELECT s.FirstName,
--	   s.LastName,
--	   e.Name
--FROM StudentExercises se
--	INNER JOIN Students s on se.StudentId = s.Id
--	INNER JOIN Exercises e on se.ExerciseId = e.Id
--;

-- 8. Return a list of student names along with the count of exercises assigned to each student.
--SELECT COUNT (se.ExerciseId) NumberOfExercisesAssigned,
--		s.FirstName,
--		s.LastName
--FROM StudentExercises se
--	INNER JOIN Students s on se.StudentId = s.Id
--GROUP BY s.FirstName, s.LastName
--;
