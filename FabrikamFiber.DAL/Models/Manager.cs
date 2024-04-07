// This is the model for the Managers who are derived from the Employee class

namespace FabrikamFiber.DAL.Models
{
    using System.Collections.Generic;
    using System.ComponentModel;

    public class Manager : Employee
    {
        public int ID { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

    }

}