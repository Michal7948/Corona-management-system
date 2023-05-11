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
    public class CovidDetailServices : ICovidDetailServices
    {
        ICovidDetailRepository repo;
        IMapper mapper;
        public CovidDetailServices(ICovidDetailRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }



        public List<CCovidDetail> GetList()
        {
            List<CovidDetail> covidDetail = repo.GetAll();
            List<CCovidDetail> cCovidDetail = mapper.Map<List<CCovidDetail>>(covidDetail);
            return cCovidDetail;
        }

        public CCovidDetail GetById(int id)
        {
            CovidDetail covidDetail = repo.GetById(id);
            CCovidDetail cCovidDetail = mapper.Map<CCovidDetail>(covidDetail);
            return cCovidDetail;
        }


        public void Create(CCovidDetail cCovidDetail)
        {
            CovidDetail covidDetail = mapper.Map<CovidDetail>(cCovidDetail);
            repo.Create(covidDetail);
        }
    

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(CCovidDetail cCovidDetail)
        {
            throw new NotImplementedException();
        }
    }
}