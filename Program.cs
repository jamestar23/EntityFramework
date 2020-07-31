using School.Controller;
using System;
using System.Collections.Generic;

//github.com/johnhinz/InClassJuly25EFCore.git

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            EFGenericRepository<StudentPoco> students = new EFGenericRepository<StudentPoco>();
            students.Add(new StudentPoco()
            {
                Courses = new List<CoursePoco>()
                {   new CoursePoco() { Name =".Net Bridging"}},

                Name = "James Estrella"
                
            });
        }
    }
}


//docs.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key