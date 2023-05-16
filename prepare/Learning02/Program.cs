using System;

class Program
{
    static void Main(string[] args)
    {
       Job job1 = new Job();
       job1._jobTitle = "Technical Support Analyst";
       job1._company = "DealerSocket";
       job1._startYear = 2016;
       job1._endYear = 2021;

       Job job2 = new Job();
       job2._jobTitle = "Technical Support Analyst";
       job2._company = "ICE Mortage Technology";
       job2._startYear = 2021;
       job2._endYear = 2023;
    }
}