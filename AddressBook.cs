using System;
using System.Collections.Generic;

namespace AddressBook
{

    public class AddressBook
    {
        public Dictionary<string, Contact> Contacts = new Dictionary<string, Contact>();
        public void AddContact(Contact contactInfoObject) //Contact is the data type AND contactInfoObject is foo 
        {

            try
            {
                Contacts.Add(contactInfoObject.Email, contactInfoObject);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Sorry it doesn't work");
            }
        }

        public Contact GetByEmail(string personsEmail)
        {
            return Contacts[personsEmail]; //Contacts the name of dictionary 
        }
    }

}
// Put Contact on line 23 because it is returning Contact and that is the data type
//created public property called contact whose value typee is dictionary. Keys are strings, values are Contact Instances