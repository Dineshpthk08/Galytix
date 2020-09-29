using DataManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataManagement.Business.Interfaces
{
    public interface IGwpManager
    {
        IList<Gwp> GetGwp(string lineOfBusiness);
    }
}
