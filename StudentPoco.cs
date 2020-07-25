using System.Collections.Generic;

//github.com/johnhinz/InClassJuly25EFCore.git

namespace School
{
    public class StudentPoco
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CoursePoco> Courses { get; set; }
    }
}


//docs.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key