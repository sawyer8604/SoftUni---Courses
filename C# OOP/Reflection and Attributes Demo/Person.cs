using System;

namespace AttrbiutesAndReflection
{
    public class Person
    {
        public string deleteMe = "Delete me...";
        private string talkContents = "bla bla";
        public Person()
        {
            // Console.WriteLine("Person()");
        }

        [Author("Stoyan")]
        protected Person(int age)
        {
            Console.WriteLine("Person(int age)");
        }

        public Person(string firstName, string lastName)
        {
            Console.WriteLine("Person(string firstName, string lastName)");
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Author("Stoyan")]
        public void Eat(string food)
        {
            // Console.WriteLine($"Eating {food}...");
        }

        [Author("Stoyan")]
        public void Walk()
        {
            Console.WriteLine("Walking...");
        }

        [Author("Niki")]
        public void Talk()
        {
            Console.WriteLine($"Talking... {talkContents}...");
        }
    }


}
