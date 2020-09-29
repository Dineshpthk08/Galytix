using Dapper;
using DataManagement.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using static System.Data.CommandType;
using DataManagement.Repository.Interfaces;

namespace DataManagement.Repository
{
    public class GwpRepository : BaseRepository, IGwpRepository
    {
        public IList<Gwp> GetGwpAvg(string country, string lineOfBusiness)
        {
            IList<Gwp> gwpList = new List<Gwp>() {
            new Gwp{ LineOfBusiness = "transport", Average=231441262.7M },
            new Gwp{ LineOfBusiness = "freight", Average=584938597.7M }
            };
            return gwpList;
        }
    }
}
