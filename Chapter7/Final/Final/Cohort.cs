using System;
using System.Collections.Generic;
using System.Text;

namespace Final
{
    class Cohort
    {

        //        Cohort
        //You must define a type for representing a cohort in code.
        //The cohort's name (Evening Cohort 6, Day Cohort 25, etc.)

        //make a constructor that accepts the cohorts name
        public Cohort(string cohortName)
        {
            CohortName = cohortName;
            Student = new List<Student>();
            Instructor = new List<Instructor>();
        }
        public string CohortName { get; set; }

        //The collection of students in the cohort.Hint: a List of<Student>
        private List<Student> Student { get; set; }
            public void AddStudent(Student newStudent)
            {
                newStudent.Cohort = this;
                Student.Add(newStudent);
            }
       
        //The collection of instructors in the cohort. Hint: a List of<Instructor>
        private List<Instructor> Instructor { get; set; }

    }
}
