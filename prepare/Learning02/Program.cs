using System;

class Program
{
    static void Main(string[] args)
    {
        // This is prep 2
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2012;
        job1._endYear = 2024;
        job1.showJobDetails();

        Job job2 = new Job();
        job2._company = "PlayStation";
        job2._jobTitle = "Programming Tester";
        job2._startYear = 2018;
        job2._endYear = 2024;
        job2.showJobDetails();

        

        Resume myResume = new Resume();
        myResume._name = "Valdemar Lasnibat";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}