using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Oracle";
        job1._startYear = 2002;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Optics Installer";
        job2._company = "E2 Optics";
        job2._startYear = 2023;
        job2._endYear = 2024;

        Resume resume1 = new Resume();
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1._name = "Hayden Billings";

        resume1.DisplayResume();
    }
}