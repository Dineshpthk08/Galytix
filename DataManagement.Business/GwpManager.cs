using DataManagement.Business.Interfaces;
using DataManagement.Entities;
using DataManagement.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataManagement.Business
{
    public class GwpManager : IGwpManager
    {
        IGwpRepository _gwpRepository;
        public GwpManager(IGwpRepository gwpRepository)
        {
            _gwpRepository = gwpRepository;
        }
        public IList<Gwp> GetGwpAvg(string country, string lineOfBusiness)
        {
            return _gwpRepository.GetGwpAvg(country, lineOfBusiness);
        }
    }
}
