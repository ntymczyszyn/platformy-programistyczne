namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of items :");
            int number_of_items = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the seed :");
            int seed = int.Parse(Console.ReadLine());
            Problem knapsack_problem = new Problem(number_of_items, seed);
            Console.WriteLine(knapsack_problem);

            Console.WriteLine("Enter the capacity :");
            int capacity = int.Parse(Console.ReadLine());
            Result result = knapsack_problem.Solve(capacity);
            Console.WriteLine(result);
        }
    }
}
