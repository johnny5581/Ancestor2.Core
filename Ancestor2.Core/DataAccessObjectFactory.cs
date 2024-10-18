using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ancestor
{
    public class DataAccessObjectFactory : IDAOFactory
    {
        public object Clone()
        {
            throw new NotImplementedException();
        }

        public IDataAccessObject GetInstance()
        {
            throw new NotImplementedException();
        }
    }
}
