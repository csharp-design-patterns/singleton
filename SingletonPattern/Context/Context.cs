using System;
using System.Data;

namespace SingletonPattern.Context
{
    public class Context : IContext
    {
        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void OpenConnection()
        {
            throw new NotImplementedException();
        }

        public IDbConnection GetConnection()
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }
    }
}
