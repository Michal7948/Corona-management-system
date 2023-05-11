using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class CovidDetail
    {
        public int Id { get; set; }
        public int IdNumber { get; set; }
        public DateTime? VaccineDate1 { get; set; }
        public DateTime? VaccineDate2 { get; set; }
        public DateTime? VaccineDate3 { get; set; }
        public DateTime? VaccineDate4 { get; set; }
        public string? VaccineManufacturer1 { get; set; }
        public string? VaccineManufacturer2 { get; set; }
        public string? VaccineManufacturer3 { get; set; }
        public string? VaccineManufacturer4 { get; set; }
        public DateTime? PositiveResultDate { get; set; }
        public DateTime? RecoveryDate { get; set; }

        public virtual PersonalDetail IdNumberNavigation { get; set; } = null!;
    }
}
