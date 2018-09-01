using System;

namespace stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Cohort cohort26 = new Cohort(){
              CohortNumber = 26
            };

            Student AprilWatson = new Student("April", "Watson");
            Student StudentTwo = new Student("stud", "two");

            Instructor FunGuy = new Instructor("Fun", "Guy");

            cohort26.Instructors.Add(FunGuy);
            cohort26.Students.Add(AprilWatson);
            cohort26.Students.Add(StudentTwo);

            Exercise StabMyself = new Exercise() {
              Name = "Stab Myself",
              GithubURL = "https://github.com/aprilrochelle",
              Language = "C#"
            };

            Exercise JumpOffBridge = new Exercise() {
              Name = "Jump Off Bridge",
              GithubURL = "https://github.com/aprilrochelle",
              Language = "C#"
            };

            FunGuy.Assign(AprilWatson, StabMyself);
            FunGuy.Assign(AprilWatson, JumpOffBridge);

            foreach (Exercise exe in AprilWatson.AssignedExercises)
            {
                Console.WriteLine($"{AprilWatson.FullName}: {exe.Name}");
            }
        }
    }
}
