using SingletonPattern.Context;

namespace SingletonPattern.Repository
{
    public class Repository
    {
        private static IContext _context;

        private Repository() { }

        public static IContext GetInstance()
        {
            if (_context is null)
            {
                _context = new Context.Context();
                _context.OpenConnection();
            }

            return _context;
        }
    }
}
