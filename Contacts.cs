using System;

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



//if have set do not need constructor but would have to write it out line by line 

//  Example of what would be in program.cs and would need to do this for everyone 
//    Contact bob = new Contact()
//             {
//                 FirstName = "Bob",
//                 LastName = "Smith",
//                 Email = "bob.smith@email.com",
//                 Address = "100 Some Ln, Testville, TN 11111"
//             };