using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppServices
{
    public interface ICovidDetailServices
    {
        List<CCovidDetail> GetList();
        CCovidDetail GetById(int id);
        void Create(CCovidDetail cCovidDetail);
        void Update(CCovidDetail cCovidDetail);
        void Delete(int id);
    }
}
