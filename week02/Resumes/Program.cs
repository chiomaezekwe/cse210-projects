using System;
class Program
{
    //static void Main(string[] args)
    static void Main()
    {
        // Creating job instances
        Job job1 = new Job("Software Engineer", "Microsoft", 2019, 2022);
        Job job2 = new Job("Manager", "Apple", 2022, 2023);

        // Creating a Resume instance and adding jobs to it
        Resume myResume = new Resume("Allison Rose");
        myResume.AddJob(job1);
        myResume.AddJob(job2);

        // Displaying the resume and the job details
        myResume.Display();

        // Creating job instances for Chioma
        Job job3 = new Job("Field Engineer", "Julius Berger", 2018, 2020);
        Job job4 = new Job("Application Support Analyst", "Interswitch", 2020, 2025);

        // Creating a Resume instance for Chioma
        Resume chiomaResume = new Resume("Ezekwe Chioma");
        chiomaResume.AddJob(job3);
        chiomaResume.AddJob(job4);

        // Displaying the resume for Chioma
        Console.WriteLine("\nResume for Ezekwe Chioma:");
        chiomaResume.Display();
    }
}