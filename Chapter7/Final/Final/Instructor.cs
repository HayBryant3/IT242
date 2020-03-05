using System;
using System.Collections.Generic;
using System.Text;

namespace Final
{
    class Instructor
    {

        //        Instructor
        //You must define a type for representing an instructor in code
        //First name
        //Last name
        public Instructor(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        private string FirstName { get; }
        private string LastName { get; }
        //Slack handle
        private string SlackHandle { get; set; }
        //The instructor's cohort
        public Cohort InstructorCohort { get; set; }
        //The instructor's specialty (e.g. jokes, snack cakes, dancing, etc.)
        public string Specialty { get; set; }
        //A method to assign an exercise to a student
        public void AddExercise(Student student, Exercise exercise)
        {
            student.Assignments.Add(exercise);
        }
    }
}
