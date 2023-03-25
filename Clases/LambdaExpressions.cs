namespace PruebasNet.Clases
{
    public class LambdaExpressions
    {
        public List<int> numbers = new List<int> { 3, 4, 7, 4, 8, 9, 2 };

        public LambdaExpressions()
        {
            Func<int, bool> GetPairs = (number) => (number % 2) == 0;

            var pairs = numbers.Where(GetPairs).ToArray();

            for(int i = 0; i < pairs.Count(); i++)
            {
                Console.WriteLine(pairs[i]);
            }
        }

        public LambdaExpressions(int x)
        {
            Action<int> print = (number) => Console.WriteLine(number);


            Action<List<int>> show = (numbers) =>
            {
                foreach(int number in numbers)
                {
                    print(number);
                }
            };
            show(numbers);
        }

        public LambdaExpressions(string name)
        {
            Func<int, Func<int, int>, int> fnHigherOrder = (number, fn) =>
            {
                if(number > 100)
                    return fn(number);
                else return number;
            };

            int res = fnHigherOrder(600, (n) => n * 2);
            Console.WriteLine(res);

        }

        
    }
}
