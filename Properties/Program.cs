using System;

namespace Properties
{

    // Properties (GET,SET) Example
    /*
    class User
    {
        private string location;
        private string name = "Praveen Rompicharla";
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string Name
        {
            get
            {
                return name.ToUpper();
            }
            set
            {
                if (value == "Praveen")
                    name = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            u.Name = "Sasi";
            u.Location = "Hyderabad";
            Console.WriteLine("Name:" +"\t" + u.Name);
            Console.WriteLine("Location:" +"\t" +u.Location);
        }
    }
    */

    // Create Read-Only Properties

   /*
    class User
    {
        private string name;
        private string location;
        public User(string a, string b) // Using Contructer
        {
            name = a;
            location = b;
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Location
        {
            get
            {
                return location;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User u = new User("Praveen Rompicharla","Hyderabad");
            Console.WriteLine("Name:" +"\t" + u.Name);
            Console.WriteLine("Location:" +"\t" + u.Location);
        }
    }
   */

    // Creating Write-Only
    /*
    class User
    {
        private string name;
        public string Name
        {
            set
            {
                name = value;
            }
        }
        private string location;
        public string Location
        {
            set
            {
                location = value;
            }
        }
        public void GetUserDetails() // Using Method
        {
            Console.WriteLine("Name:" +"\t" + name);
            Console.WriteLine("Location" +"\t" + location);
        }
    }
    class Program
    {
       static void Main(string[] args)
        {
            User u = new User();
            u.Name = "Praveen";
            u.Location = "Hyd";
            u.GetUserDetails();
        }
    } */
    // Auto Implemented Properties

    class User
    {
        public string Name { get; set; }
        public string Location { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            u.Name = "Praveen";
            u.Location = "Hyd";
            Console.WriteLine("Name:" + "\t" + u.Name);
            Console.WriteLine("Location:" + "\t" + u.Location);
        }
    }
}
