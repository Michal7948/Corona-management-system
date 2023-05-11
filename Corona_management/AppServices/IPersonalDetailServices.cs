using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppServices
{
    public interface IPersonalDetailServices
    {
        List<CPersonalDetail> GetList();
        CPersonalDetail GetById(int id);
        void Create(CPersonalDetail cPersonalDetail);
        void Update(CPersonalDetail cPersonalDetail);
        void Delete(int id);
    }
}
