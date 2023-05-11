using AutoMapper;
using Common;
using Repositories;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppServices
{
    public class PersonalDetailServices:IPersonalDetailServices
    {
        IPersonalDetailRepository repo;
        IMapper mapper;

        public PersonalDetailServices(IPersonalDetailRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;

        }

        public List<CPersonalDetail> GetList()
        {
            List<PersonalDetail> personalDetail = repo.GetAll();
            List<CPersonalDetail> cPersonalDetail = mapper.Map<List<CPersonalDetail>>(personalDetail);
            return cPersonalDetail;
        }

        public CPersonalDetail GetById(int id)
        {
            PersonalDetail personalDetail = repo.GetById(id);
            CPersonalDetail cPersonal = mapper.Map<CPersonalDetail>(personalDetail);
            return cPersonal;
        }

        public void Create(CPersonalDetail cPersonalDetail)
        {
            PersonalDetail personalDetail = mapper.Map<PersonalDetail>(cPersonalDetail);
            repo.Create(personalDetail);
        }

        public void Update(CPersonalDetail cPersonalDetail)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
