using System;

namespace Assignment_B_Mobile_App
{
    public abstract class Person
    {
        protected string name { get; set; }

        public Person(string name)
        {
            this.name = name;
        }
        
    }

  
}