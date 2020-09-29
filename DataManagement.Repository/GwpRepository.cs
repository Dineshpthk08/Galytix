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
        public IList<Gwp> GetGwp(string lineOfBusiness)
        {
            IList<Gwp> gwpList = new List<Gwp>();
            return gwpList;
        }
    }
}
