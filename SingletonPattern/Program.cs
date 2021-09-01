using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton Sample...");

            var repository1 = Repository.Repository.GetInstance();
            var repository2 = Repository.Repository.GetInstance();

            if (repository1 is not null && repository1.Equals(repository2))
                Console.WriteLine("Singleton works.");
            else
                throw new InvalidOperationException("Singleton failed.");
        }
    }
}
