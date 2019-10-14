using System;
using System.Collections.Generic;

namespace StudentExercises {
    public class Cohort {
        public string Name { get; }
        public List<Instructor> InstructorList = new List<Instructor> ();  
        public List<Student> StudentList = new List<Student> ();
        //constructor
        public Cohort (string name) {
            Name = name;
        }
        // method to add students to cohort
        public void AddStudents(Student student) {
            StudentList.Add(student);
            student.Cohort = this;
        }
    }
}