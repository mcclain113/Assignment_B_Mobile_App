using System;
using Assignment_B_Mobile_App.Properties;

namespace Assignment_B_Mobile_App;

public class Teacher : Person, ITalkable
{
    private int age { get; set; }
    
    public string Talk()
    {
        return "Don't forget to do the assigned reading!";
    }

    public string GetName()
    {
        return $"{name}";
    }


    public Teacher(int age, string name) : base(name)
    {
        this.age = age;
    }
      
    
}

