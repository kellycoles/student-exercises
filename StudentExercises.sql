-------------------
---- CREATE TABLES
-------------------

--CREATE TABLE Cohort (
--    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
--    CohortName VARCHAR(55) NOT NULL
--	);

--CREATE TABLE Student (
--    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
--    FirstName VARCHAR(55) NOT NULL,
--	LastName VARCHAR(55) NOT NULL,
--	SlackHandle VARCHAR(55) NOT NULL,
--	CohortId INTEGER NOT NULL,
--  CONSTRAINT FK_Student_Cohort FOREIGN KEY(CohortId) REFERENCES Cohort(Id)
--	);

--CREATE TABLE Instructor (
--    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
--    FirstName VARCHAR(55) NOT NULL,
--	LastName VARCHAR(55) NOT NULL,
--	SlackHandle VARCHAR(55) NOT NULL,
--	Speciality VARCHAR(55) NOT NULL,
--	CohortId INTEGER NOT NULL,
--	CONSTRAINT FK_Instructor_Cohort FOREIGN KEY(CohortId) REFERENCES Cohort(Id)
--	);


--CREATE TABLE Exercise (
--    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
--    ExerciseName VARCHAR(55) NOT NULL,
--	ExerciseLanguage VARCHAR(55) NOT NULL
--	);

--CREATE TABLE StudentExercise (
--    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
--	StudentId INTEGER NOT NULL,
--	ExerciseId INTEGER NOT NULL,
--	CONSTRAINT FK_StudentExercises_Student FOREIGN KEY(StudentId) REFERENCES Student(Id),
--	CONSTRAINT FK_StudentExercises_Exercise FOREIGN KEY(ExerciseId) REFERENCES Exercise(Id)
--	);


--------------------
---- CREATE STUDENT 
--------------------

--INSERT INTO Student(FirstName, LastName,SlackHandle, CohortId)ValUES('Kelly', 'Coles', 'kellycoles', 1);
--INSERT INTO Student(FirstName, LastName,SlackHandle, CohortId)ValUES('Jane', 'Doe', 'doeGirl', 3)
--INSERT INTO Student(FirstName, LastName,SlackHandle, CohortId)ValUES('Jack', 'Black', 'blackish', 1)
--INSERT INTO Student(FirstName, LastName,SlackHandle, CohortId)ValUES('Sam', 'Spam', 'iamsam', 3)
--INSERT INTO Student(FirstName, LastName,SlackHandle, CohortId)ValUES('Seth', 'Slacker', 'slacking', 1)

-----------------------
----  CREATE INSTRUCTOR
-----------------------

--INSERT INTO Instructor(FirstName, LastName,SlackHandle,Speciality, CohortId)VALUES('Steve', 'Brownlee', 'coach','jokes', 3);
--INSERT INTO Instructor(FirstName, LastName,SlackHandle,Speciality, CohortId)VALUES('Andy', 'Collins', 'askinalot','funny', 1);
--INSERT INTO Instructor(FirstName, LastName,SlackHandle,Speciality, CohortId)VALUES('Bryan', 'Neilson', 'highfivin','drawing', 2);
--INSERT INTO Instructor(FirstName, LastName,SlackHandle,Speciality, CohortId)VALUES('Jenna', 'Solis', 'taco','being sweet', 4);
--INSERT INTO Instructor(FirstName, LastName,SlackHandle,Speciality, CohortId)VALUES('Adam', 'Schafer', 'coolDude','funny', 2);

---------------------
---- CREATE EXERCISE
---------------------

--INSERT INTO Exercise (ExerciseName ,ExerciseLanguage)VALUES('chicken monkey', 'JavaScript');
--INSERT INTO Exercise (ExerciseName ,ExerciseLanguage)VALUES('coffee', 'CSS');
--INSERT INTO Exercise (ExerciseName ,ExerciseLanguage)VALUES('html-components', 'HTML');
--INSERT INTO Exercise (ExerciseName ,ExerciseLanguage)VALUES('Urban Planner', 'C#');

-------------------
---- CREATE COHORT
-------------------

--iNSERT INTO Cohort(CohortName)VALUES('cohort-34');
--iNSERT INTO Cohort(CohortName)VALUES('cohort-35');
--iNSERT INTO Cohort(CohortName)VALUES('cohort-36');
--iNSERT INTO Cohort(CohortName)VALUES('cohort-37');

--------------------------------------
---- GIVE THE STUDENTS SOME EXERCISES
--------------------------------------

--INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES(2,3);
--INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES(2,1);
--INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES(3,4);
--INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES(3,2);
--INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES(1,3);
--INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES(1,4);
--INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES(4,2);
--INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES(4,3);
--INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES(4,1);

----------------------------------------------------------------------------------------------------------------
-- 3 Write a query to return all student first and last names with their cohort's name.

--SELECT Student.FirstName, Student.LastName, CohortName
--FROM Student
--JOIN Cohort
--ON Student.CohortId = Cohort.Id

-----------------------------------------------------------------------------------------------------------------
--4 Write a query to return student first and last names with their cohort's name only for a single cohort.

--SELECT Student.FirstName, Student.LastName, CohortName
--FROM Student
--JOIN Cohort
--ON Student.CohortId = Cohort.Id
--WHERE CohortId =1

-----------------------------------------------------------------------------------------------------------------
--5 Write a query to return all instructors ordered by their last name

--SELECT Instructor.LastName, Instructor.FirstName
--FROM Instructor
--ORDER BY LastName

---------------------------------------------------------------------------------------------------------------------------------
--6 Write a query to return a list of unique instructor specialties.

--SELECT Distinct Speciality
--FROM Instructor

----------------------------------------------------------------------------------------------------------------------------------
--7 Write a query to return a list of all student names along with the names of the exercises they have been assigned.
--If an exercise has not been assigned, it should not be in the result.

--SELECT DISTINCT  Student.FirstName +' '+ Student.LastName AS 'Name', Exercise.ExerciseName +','As 'Exercise'
--From StudentExercise
--JOIN Student
--ON StudentExercise.StudentId = Student.Id
--JOIN Exercise
--ON StudentExercise.ExerciseId = Exercise.Id

------------------------------------------------------------------------------------------------------------------------------------
-- 8 Return a list of student names along with the count of exercises assigned to each student.
--SELECT Student.FirstName, Student.LastName  , COUNT(ExerciseId)As'Number of Exercises'
--FROM Student
--Join StudentExercise
--ON StudentExercise.StudentId = Student.Id
--GROUP BY LastName,FirstName 




