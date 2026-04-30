using System;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program166_MockingUsingMoq
    {
        public static void Run()
        {
            IUserRepository repository = new FakeUserRepository();
            UserService service = new UserService(repository);
            Console.WriteLine(service.GetWelcomeMessage(1));
        }

        private interface IUserRepository
        {
            string GetNameById(int id);
        }

        private class FakeUserRepository : IUserRepository
        {
            public string GetNameById(int id) => "Ajinkya";
        }

        private class UserService
        {
            private readonly IUserRepository repository;

            public UserService(IUserRepository repository)
            {
                this.repository = repository;
            }

            public string GetWelcomeMessage(int id) => $"Welcome, {repository.GetNameById(id)}";
        }
    }
}
