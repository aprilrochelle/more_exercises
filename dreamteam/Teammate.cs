using System;
namespace dreamteam
{
  public class Teammate
  {
    public string Specialty { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get => $"{FirstName} {LastName}"; }
    public void Work(){
      Console.WriteLine($"{FirstName}, go forth, {Specialty}!");
    }

  }
}