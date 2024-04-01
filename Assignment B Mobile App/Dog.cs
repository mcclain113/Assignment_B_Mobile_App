using System.Net.Configuration;
using System.Reflection.Emit;
using Assignment_B_Mobile_App.Properties;

namespace Assignment_B_Mobile_App;

public class Dog : Pet, ITalkable
{

    private bool friendly;
    
    
    
    public Dog(string name, bool friendly) : base(name)
    {
        this.friendly = friendly;
    }

    public bool IsFriendly()
    {
        return friendly;
    }

    public string Talk()
    {
        return "Bark";
    }
    
    public override string ToString()
    {
        return $"Dog: name={name} friendly={friendly}";
    }
    
}