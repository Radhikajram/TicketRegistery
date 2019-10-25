namespace TicketRegistery
{

    // Class contains the details of a person - name,age,Ticket price
   public class Person
    {
       public string name { get; set; }
       public int age { get; set; }

        public int ticketPrice { get; set; }

        public int getTicketPrice 
        {
            get
            {
                if ((age < 10) | (age > 100))
                {
                    return 0;
                }
                else if (age < 20)
                {
                    return 80;
                }
                else if (age > 64)
                {
                    return 90;
                }
                else
                {
                    return 120;
                }
            }
        }

       

        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
           // this.ticketPrice = ticketPrice;

        }
        public Person(string name, int age,int ticketPrice)
        {
            this.name = name;
            this.age = age;
            this.ticketPrice = ticketPrice;

        }
        public override string ToString()
        {
            return $"Name: {name} Age: {age} TicketPrice: {ticketPrice}";
        }
    }
}