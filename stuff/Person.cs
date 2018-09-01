namespace stuff
{
  public class Person
  {
    protected string _firstName;
    protected string _lastName;
    public string FullName { get => $"{_firstName} {_lastName}"; }
  }
}