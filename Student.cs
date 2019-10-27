using System;
using System.Collections.Generic;

namespace StudentExercises {
    public class Student : NSSPerson {
      
        public List<Exercise> ExerciseList = new List<Exercise> ();
        //constructors
        public Student (string fname, string lname, string slack) {
            FirstName = fname;
            LastName = lname;
            SlackHandle = slack;
           
        }
    }
}