using System;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program193_CleanArchitectureImplementation
    {
        public static void Run()
        {
            IOrderRepository repository = new InMemoryOrderRepository();
            CreateOrderUseCase useCase = new CreateOrderUseCase(repository);
            useCase.Execute("SO-101");
        }

        private class CreateOrderUseCase
        {
            private readonly IOrderRepository repository;

            public CreateOrderUseCase(IOrderRepository repository)
            {
                this.repository = repository;
            }

            public void Execute(string orderNumber)
            {
                repository.Save(orderNumber);
                Console.WriteLine($"Use case executed for order {orderNumber}");
            }
        }

        private interface IOrderRepository
        {
            void Save(string orderNumber);
        }

        private class InMemoryOrderRepository : IOrderRepository
        {
            public void Save(string orderNumber)
            {
                Console.WriteLine($"Infrastructure saved order {orderNumber}");
            }
        }
    }
}
