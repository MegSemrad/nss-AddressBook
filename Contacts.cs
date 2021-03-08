namespace AddressBook
{

    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}


// Two ways to add instance of object

// 1. Can do it the way set up here (i.e. w/o constractor, use {get; set; }, and the below example of a new object that would need to live in program.cs)
//    Contact bob = new Contact()
//             {
//                 FirstName = "Bob",
//                 LastName = "Smith",
//                 Email = "bob.smith@email.com",
//                 Address = "100 Some Ln, Testville, TN 11111"
//             };

// 2. Have no { set; }, use constructor, and in program.js would pass new info in as parameters