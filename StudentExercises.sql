CREATE TABLE Cohorts (
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    Name VARCHAR(55) NOT NULL
);

  
CREATE TABLE Exercises (
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    Name VARCHAR(55) NOT NULL,
    Language VARCHAR(55) NOT NULL
);

CREATE TABLE Students (
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    FirstName VARCHAR(55) NOT NULL,
    LastName VARCHAR(55) NOT NULL,
    SlackHandle VARCHAR(55) NOT NULL,
    CohortId INTEGER NOT NULL,
    CONSTRAINT FK_Student_Cohort FOREIGN KEY(CohortId) REFERENCES Cohort(Id)
);

CREATE TABLE Instructors (
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    FirstName VARCHAR(55) NOT NULL,
    LastName VARCHAR(55) NOT NULL,
    SlackHandle VARCHAR(55) NOT NULL,
    Specialty VARCHAR(55) NOT NULL,
    CohortId INTEGER NOT NULL,
    CONSTRAINT FK_Instructor_Cohort FOREIGN KEY(CohortId) REFERENCES Cohort(Id)
);

CREATE TABLE StudentExercises (
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    StudentId INTEGER NOT NULL,
    ExerciseId INTEGER NOT NULL,
    CONSTRAINT FK_Student_Cohort FOREIGN KEY(CohortId) REFERENCES Cohort(Id),

);

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
