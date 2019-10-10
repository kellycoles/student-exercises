using System;

namespace StudentExercises {
    public class Exercise {
        public string Name { get; set; }
        public string Language { get; set; }

        //constructors
        public Exercise () { }
        public Exercise (string name, string language) {
            Name = name;
            Language = language;

        }
    }
}