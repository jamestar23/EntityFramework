//github.com/johnhinz/InClassJuly25EFCore.git

namespace School
{
    public class MarkPoco
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }

        //[Key] alternative - see line 28
        public CoursePoco Course { get; set; } // relationship of the poco
        //[Key]
        public StudentPoco Student { get; set; }
        public int Mark { get; set; }
    }
}


//docs.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key