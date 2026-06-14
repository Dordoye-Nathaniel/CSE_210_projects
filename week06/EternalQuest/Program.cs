class Program
{
    static void Main()
    {
        // Added ProgressGoals() as exceeding requirements 
        System.Console.WriteLine("Program starting....");
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}