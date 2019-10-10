using System;
using System.Collections.Generic;

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
            Student student1 = new Student ("Kelly", "Coles", "kellycoles", c34);
            Student student2 = new Student ("Jane", "Doe", "doegirl", c35);
            Student student3 = new Student ("Jack", "Black", "blackish", c36);
            Student student4 = new Student ("Sam", "Spam", "iamsam", c34);

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

            //Add students to list
            List<Student> Students = new List<Student> () {
                student1,
                student2,
                student3,
                student4
            };

            //Add instructor to list
            List<Exercise> Exercises = new List<Exercise> () {
                exercise1,
                exercise2,
                exercise3,
                exercise4
            };

            foreach (Exercise exe in Exercises) {
                Console.WriteLine();
                Console.WriteLine ($"Students working on: {exe.Name}");
                Console.WriteLine("-----------------------------------------------------------------");
                foreach (Student stu in Students) {
                   
                        if (stu.ExerciseList.Contains(exe)) {
                            Console.WriteLine ($"{stu.FirstName} {stu.LastName}");
                        }

                };
            }
        }
    }
}