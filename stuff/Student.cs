using System;
using System.Collections.Generic;

namespace stuff
{
  public class Student : Person
  {
    public List<Exercise> AssignedExercises { get; } = new List<Exercise>();

    public Student(string firstName, string lastName) {
      _firstName = firstName;
      _lastName = lastName;
    }
  }
}
