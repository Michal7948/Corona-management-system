using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CovidDetailRepository : ICovidDetailRepository
    {
        Corona_managementContext context;

        public CovidDetailRepository(Corona_managementContext context)
        {
            this.context = context;
        }

        public void Create(CovidDetail objToCreate)
        {
            context.CovidDetails.Add(objToCreate);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CovidDetail> GetAll()
        {
            return context.CovidDetails.ToList();
        }

        public CovidDetail GetById(int id)
        {
            CovidDetail covidId = context.CovidDetails.Where(d => d.IdNumber == id).FirstOrDefault();
            if (covidId != null)
            {
                return covidId;
            }
            return null;
        }

        public void Update(CovidDetail objToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
