using DataManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataManagement.Repository.Interfaces
{
    public interface IGwpRepository
    {
        IList<Gwp> GetGwpAvg(string country, string lineOfBusiness);
    }
}
