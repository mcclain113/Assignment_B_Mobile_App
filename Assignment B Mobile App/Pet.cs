using System;

namespace Assignment_B_Mobile_App;

public abstract class Pet
{

    protected string name;
    
    public Pet(String name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }
}

