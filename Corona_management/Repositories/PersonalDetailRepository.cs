using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class PersonalDetailRepository:IPersonalDetailRepository
    {
        Corona_managementContext context;

        public PersonalDetailRepository(Corona_managementContext context)
        {
            this.context = context;
        }

        public void Create(PersonalDetail objToCreate)
        {
            //context.PersonalDetails.Add(new PersonalDetail
            //{
            //    Id = objToCreate.Id,
            //    IdNumber = objToCreate.IdNumber,
            //    FirstName = objToCreate.FirstName,
            //    LastName = objToCreate.LastName,
            //    City = objToCreate.City,
            //    Street = objToCreate.Street,
            //    NumberStreet = objToCreate.NumberStreet,
            //    DateOfBirth = objToCreate.DateOfBirth,
            //    PhoneNumber = objToCreate.PhoneNumber,
            //    MobileNumber = objToCreate.MobileNumber
            //});
            context.PersonalDetails.Add(objToCreate);

            context.SaveChanges();      
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<PersonalDetail> GetAll()
        {
            return context.PersonalDetails.ToList();
        }

        public PersonalDetail GetById(int id)
        {
            PersonalDetail personalId = context.PersonalDetails.Where(d => d.IdNumber == id).FirstOrDefault();
            if (personalId!=null)
            {
                return personalId;
            }
            return null;
        }

        public void Update(PersonalDetail objToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
