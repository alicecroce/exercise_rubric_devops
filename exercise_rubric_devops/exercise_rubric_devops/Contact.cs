namespace exercise_rubric_devops
{
    internal class Contact
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public Contact(string name, string lastName)
        {
            Name = name;
            LastName = lastName;    
        }

        public string ShowContact(string name, string lastName)
        {
            return $"First name: {Name} | Last name: {LastName} ";
        }
    }

    
}
