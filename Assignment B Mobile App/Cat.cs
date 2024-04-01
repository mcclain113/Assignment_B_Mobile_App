using Assignment_B_Mobile_App.Properties;

namespace Assignment_B_Mobile_App;

public class Cat : Pet, ITalkable
{
    public int mousesKilled { get; set; }
    
    public Cat(int mousesKilled,string name) : base(name)
    {
        this.mousesKilled = mousesKilled;
    }

    public string Talk()
    {
        return "Meow";
    }

    public void AddMouse()
    {
        mousesKilled++;}
    
    public override string ToString()
    {
        return $"Cat name= {name} and mouses killed= {mousesKilled}";
    }
}