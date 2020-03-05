using System.Collections.Generic;

namespace Final
{
    class Student
    {

        //        Student


        //Properties

        //First name of type string
        //Last name of type string
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Assignments = new List<Exercise>();
        }
        private string FirstName { get; }
        private string LastName { get; }
        //Slack handle of type string
        private string SlackHandle { get; set; }

        //The student's cohort of type Cohort(the next custom class you will create in this assignment)
        public Cohort Cohort { get; set; }
    //The collection of exercises that the student is currently working on.Hint: A List of type Exercise
        public List<Exercise> Assignments { get; set; }
    }
}
