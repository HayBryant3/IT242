using System;

namespace Final
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Create 4, or more, exercises.
            Exercise Assignment1 = new Exercise
            {
                name = "Assignment 1",
                languageType = "C#"

            };
            Exercise Assignment2 = new Exercise
            {
                name = "Assignment 2",
                languageType = "C#"

            };
            Exercise Assignment3 = new Exercise
            {
                name = "Assignment 3",
                languageType = "C#"

            };
            Exercise Assignment4 = new Exercise
            {
                name = "Assignment 4",
                languageType = "C#"

            };

            //Create 3, or more, cohorts.
            Cohort Cohort1 = new Cohort("Programming101");
            Cohort Cohort2 = new Cohort("Programming102");
            Cohort Cohort3 = new Cohort("Programming103");

            //Create 4, or more, students and assign them to one of the cohorts.
            Student BillyBob = new Student("Billy", "Bob");
            Cohort1.AddStudent(BillyBob);
            Student JoeSmith = new Student("Joe", "Smith");
            Cohort2.AddStudent(JoeSmith);
            Student HaileeBryant = new Student("Hailee", "Bryant");
            Cohort3.AddStudent(HaileeBryant);
            Student JimmyJohn = new Student("Jimmy", "John");
            Cohort1.AddStudent(JimmyJohn);

            //Create 3, or more, instructors and assign them to one of the cohorts.

            Instructor RussellMiller = new Instructor("Russell", "Miller");
            {
                Cohort InstructorCohort = Cohort1;
            }
            Instructor KimPreece = new Instructor("Kim", "Preece");
            {
                Cohort InstructorCohort = Cohort2;
            }
            Instructor JulieTerry = new Instructor("Julie", "Terry");
            {
                Cohort InstructorCohort = Cohort3;
            }

            //Have each instructor assign 2 exercises to each of the students.
            RussellMiller.AddExercise(BillyBob, Assignment1);
            RussellMiller.AddExercise(BillyBob, Assignment2);
            RussellMiller.AddExercise(JoeSmith, Assignment3);
            RussellMiller.AddExercise(JoeSmith, Assignment4);
            RussellMiller.AddExercise(HaileeBryant, Assignment1);
            RussellMiller.AddExercise(HaileeBryant, Assignment2);
            RussellMiller.AddExercise(JimmyJohn, Assignment3);
            RussellMiller.AddExercise(JimmyJohn, Assignment4);

            KimPreece.AddExercise(BillyBob, Assignment1);
            KimPreece.AddExercise(BillyBob, Assignment2);
            KimPreece.AddExercise(JoeSmith, Assignment3);
            KimPreece.AddExercise(JoeSmith, Assignment4);
            KimPreece.AddExercise(HaileeBryant, Assignment1);
            KimPreece.AddExercise(HaileeBryant, Assignment2);
            KimPreece.AddExercise(JimmyJohn, Assignment3);
            KimPreece.AddExercise(JimmyJohn, Assignment4);

            JulieTerry.AddExercise(BillyBob, Assignment1);
            JulieTerry.AddExercise(BillyBob, Assignment2);
            JulieTerry.AddExercise(JoeSmith, Assignment3);
            JulieTerry.AddExercise(JoeSmith, Assignment4);
            JulieTerry.AddExercise(HaileeBryant, Assignment1);
            JulieTerry.AddExercise(HaileeBryant, Assignment2);
            JulieTerry.AddExercise(JimmyJohn, Assignment3);
            JulieTerry.AddExercise(JimmyJohn, Assignment4);
            Console.WriteLine("Debug Line");
        }
      
    }
}

