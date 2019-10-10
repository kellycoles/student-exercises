using System;

namespace StudentExercises {
    public class Instructor{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public string SpecialTalent {get; set;}
        public Cohort Cohort { get; set; }
        public void AssignStudentExercises(Student student, Exercise exercise) {
            student.ExerciseList.Add(exercise);
        }
        //constructors
        public Instructor () { }
        public Instructor (string fname, string lname, string slack, string specTalent, Cohort cohort) {
            FirstName = fname;
            LastName = lname;
            SlackHandle = slack;
            SpecialTalent = specTalent;
            Cohort = cohort;
        }
    }
}