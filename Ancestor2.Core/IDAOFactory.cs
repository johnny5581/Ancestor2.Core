using System;

namespace Ancestor
{
    public interface IDAOFactory : ICloneable
    {
        IDataAccessObject GetInstance();
    }
}
