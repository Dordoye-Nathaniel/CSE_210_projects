using System;

public class Resume
{
    public string _name;


    public List<Job> _jobs = new List<Job>();

    // Initialize your list to a new list
    public void Display()
    {
        System.Console.WriteLine($"Name: {_name}");
        System.Console.WriteLine("Jobs: ");

        
        foreach(var job in _jobs)
        {
            // Display jobs in Job
            job.Display();
        }

    }
    

}
