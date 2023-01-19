using System;
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Microsoft", "Software Engineer", 2019, 2022);
        Job job2 = new Job("Apple", "Manager", 2022, 2023);

        Resume myResume = new Resume();
        myResume.Name = "Allison Rose";
        myResume.Jobs.Add(job1);
        myResume.Jobs.Add(job2);

        myResume.Display();
    }
}