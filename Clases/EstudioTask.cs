namespace PruebasNet.Clases
{
    public class EstudioTask
    {
        public async Task<int> FuncionAsincrona()
        {
            var task = new Task(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("La tarea interna del task");
            });
            task.Start();

            var task2 = new Task(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("La tarea interna 2 del task");
            });
            task2.Start();

            Console.WriteLine("Sigo haciendo algo más");

            await task;
            await task2;

            int resultRandom = await RandomAsync();
            Console.WriteLine(resultRandom);

            Console.WriteLine("He terminado la tarea");

            Console.ReadLine();

            return 0;
        }

        public async Task<int> RandomAsync()
        {
            var task = new Task<int>(() => new Random().Next(1000));
            task.Start();
            int result = await task;
            return result;
        }

    }
}
