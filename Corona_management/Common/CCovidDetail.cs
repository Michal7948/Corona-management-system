using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class CCovidDetail
    {

        public int IdNumber { get; set; }
        public DateTime Vaccine_date1 { get; set; }
        public DateTime Vaccine_date2 { get; set; }
        public DateTime Vaccine_date3 { get; set; }
        public DateTime Vaccine_date4 { get; set; }
        public string Vaccine_manufacturer1 { get; set; }
        public string Vaccine_manufacturer2 { get; set; }
        public string Vaccine_manufacturer3 { get; set; }
        public string Vaccine_manufacturer4 { get; set; }
        public DateTime Positive_result_date { get; set; }
        public DateTime Recovery_date { get; set; }



    }
}
