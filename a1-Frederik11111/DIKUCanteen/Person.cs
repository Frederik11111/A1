using System.Reflection.Metadata.Ecma335;

namespace DIKUCanteen;

public class Person{
  public string Name { get; }
  public string Occupation { get; }
  public int Age { get; }
  
  public Person(string name, string occupation, int age)
  {
    Name = name;
    Occupation = occupation;
    Age = age;
  }
}
