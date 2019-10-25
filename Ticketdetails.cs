using System;
using System.Collections.Generic;
using System.Text;

namespace TicketRegistery
{
    // The class has two method addPerson - To add person details to List 
    // getPersonList -  To Get list of person and their ticket details.

    class Ticketdetails
    {
        private List<Person> person;

      public Ticketdetails()
        {
            person = new List<Person>();
        }
       
     public  void addPerson(string name, int age,int TicketPrice)
        {
            Person persondetails = new Person(name,age,TicketPrice);
            person.Add(persondetails);

        }

        
       public Person[] getPersonList()
        {
            return person.ToArray();
                 
        }
    }
}
