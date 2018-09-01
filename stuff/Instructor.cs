namespace stuff
{
  public class Instructor : Person
  {
    public Instructor(string firstName, string lastName) {
      _firstName = firstName;
      _lastName = lastName;
    }

    public void Assign(Student student, Exercise exercise){
      student.AssignedExercises.Add(exercise);
    }
  }
}
