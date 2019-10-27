using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises {
    class Program {
        static void Main (string[] args) {

            // Add exercises 
            Exercise exercise1 = new Exercise ("Chicken Monkey", "JavaScript");
            Exercise exercise2 = new Exercise ("coffee", "css");
            Exercise exercise3 = new Exercise ("html-components", "html");
            Exercise exercise4 = new Exercise ("Urban Planner", "C#");

            //Add Cohorts
            Cohort c34 = new Cohort ("Cohort-34");
            Cohort c35 = new Cohort ("Cohort-35");
            Cohort c36 = new Cohort ("Cohort-36");

            //Add Students
            Student student1 = new Student ("Kelly", "Coles", "kellycoles");
            Student student2 = new Student ("Jane", "Doe", "doegirl");
            Student student3 = new Student ("Jack", "Black", "blackish");
            Student student4 = new Student ("Sam", "Spam", "iamsam");
            Student student5 = new Student ("Seth", "Slacker", "slacking");

            //Add Instructors
            Instructor instructor1 = new Instructor ("Steve", "Brownlee", "sbrownlee", "jokes", c35);
            Instructor instructor2 = new Instructor ("Andy", "Collins", "askinalot", "funny", c34);
            Instructor instructor3 = new Instructor ("Bryan", "Neilson", "highfivin", "drawing", c34);
            Instructor instructor4 = new Instructor ("Jenna", "Solis", "jsolis", "tacos", c34);

            // Assign Exercises
            instructor1.AssignStudentExercises (student2, exercise3);
            instructor1.AssignStudentExercises (student2, exercise1);
            instructor4.AssignStudentExercises (student3, exercise4);
            instructor3.AssignStudentExercises (student3, exercise2);
            instructor2.AssignStudentExercises (student1, exercise3);
            instructor4.AssignStudentExercises (student1, exercise4);
            instructor3.AssignStudentExercises (student4, exercise2);
            instructor2.AssignStudentExercises (student4, exercise3);
            instructor2.AssignStudentExercises (student4, exercise1);

            //Add students to list
            List<Student> students = new List<Student> () {
                student1,
                student2,
                student3,
                student4,
                student5
            };

            // Assign students to cohort
            c35.AddStudents (student1);
            c36.AddStudents (student2);
            c34.AddStudents (student3);
            c36.AddStudents (student4);
            c34.AddStudents (student5);

            //Add exercise to list
            List<Exercise> exercises = new List<Exercise> () {
                exercise1,
                exercise2,
                exercise3,
                exercise4
            };

            //Add instructor to list
            List<Instructor> instructors = new List<Instructor> () {
                instructor1,
                instructor2,
                instructor3,
                instructor4
            };

            //Add Cohort to list
            List<Cohort> cohorts = new List<Cohort> () {
                c34,
                c35,
                c36
            };

            // Output what students are working on
            foreach (Exercise exe in exercises) {
                Console.WriteLine ();
                Console.WriteLine ($"Students working on: {exe.Name}");
                Console.WriteLine ("-----------------------------------------------------------------");
                foreach (Student stu in students) {

                    if (stu.ExerciseList.Contains (exe)) {
                        Console.WriteLine ($"{stu.FirstName} {stu.LastName}");
                    }
                };
            }
            //=====================================================================================
            // PART 2
            //=====================================================================================

            // 1. List exercises for the JavaScript language by using the Where() LINQ method.
            Console.WriteLine ();
            Console.WriteLine ("Exercises that use JavaScript:");
            Console.WriteLine ("-----------------------------");
            List<Exercise> jsExercises = exercises.Where (n => n.Language == "JavaScript").ToList ();
            foreach (Exercise exe in jsExercises) {
                Console.WriteLine (exe.Name);
            }

            // 2. List students in a particular cohort by using the Where() LINQ method.
            Console.WriteLine ();
            Console.WriteLine ("Students in cohort 36:");
            Console.WriteLine ("-----------------------------");
            List<Student> c36Students = students.Where (n => n.Cohort == c36).ToList ();
            foreach (Student stu in c36Students) {
                Console.WriteLine (stu.FirstName);
            }

            // 3. List instructors in a particular cohort by using the Where() LINQ method.
            Console.WriteLine ();
            Console.WriteLine ("Instructors in cohort 34:");
            Console.WriteLine ("-----------------------------");
            List<Instructor> c34Instructors = instructors.Where (n => n.Cohort == c34).ToList ();
            foreach (Instructor ins in c34Instructors) {
                Console.WriteLine (ins.FirstName);
            }

            // 4. Sort the students by their last name.
            Console.WriteLine ();
            Console.WriteLine ("Students sorted by last name:");
            Console.WriteLine ("-----------------------------");
            List<Student> studentSort = students.OrderBy (n => n.LastName).ToList ();
            foreach (Student stu in studentSort) {
                Console.WriteLine (stu.LastName);
            }

            // 5. Display any students that aren't working on any exercises (Make sure one of your student instances don't have any exercises. Create a new student if you need to.)
            Console.WriteLine ();
            Console.WriteLine ("Students with no exercises:");
            Console.WriteLine ("-----------------------------");
            List<Student> StudentsNoExe = students.Where (n => n.ExerciseList.Count == 0).ToList ();
            foreach (Student stu in StudentsNoExe) {
                Console.WriteLine (stu.FirstName);
            }

            // 6. Which student is working on the most exercises? Make sure one of your students has more exercises than the others.
            Console.WriteLine ();
            Console.WriteLine ("Student working on the most exercises:");
            Console.WriteLine ("-----------------------------");
            List<Student> StudentMostExe = students.OrderByDescending (n => n.ExerciseList.Count ()).ToList ();
            Console.WriteLine (StudentMostExe[0].FirstName);

            // 7. How many students in each cohort?
            foreach (Cohort c in cohorts) {
                Console.WriteLine ();
                Console.WriteLine ($"Students in: {c.Name}");
                Console.WriteLine ("-----------------------------------------------------------------");
                Console.WriteLine (c.StudentList.Count ());
            }
        }
    }
}