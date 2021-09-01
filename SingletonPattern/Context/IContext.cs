using System.Data;

namespace SingletonPattern.Context
{
    public interface IContext
    {
        void OpenConnection();

        void Commit();

        void Rollback();

        IDbConnection GetConnection();
    }
}
