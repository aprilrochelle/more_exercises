using System;
using System.Collections.Generic;

namespace stuff
{
  public class Cohort
  {
    public List<Student> Students { get; set; } = new List<Student>();
    public List<Instructor> Instructors { get; set; } = new List<Instructor>();

    public int CohortNumber { get; set; }
  }
}