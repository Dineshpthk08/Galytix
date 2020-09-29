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
        public IList<Gwp> GetGwp(string lineOfBusiness)
        {
            return _gwpRepository.GetGwp(lineOfBusiness);
        }
    }
}
