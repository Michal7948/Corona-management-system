using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class PersonalDetail
    {
        public PersonalDetail()
        {
            CovidDetails = new HashSet<CovidDetail>();
        }

        public int Id { get; set; }
        public int IdNumber { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Street { get; set; } = null!;
        public int NumberStreet { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public string MobileNumber { get; set; } = null!;

        public virtual ICollection<CovidDetail> CovidDetails { get; set; }
    }
}
