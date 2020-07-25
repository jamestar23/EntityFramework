using System.ComponentModel.DataAnnotations;

//github.com/johnhinz/InClassJuly25EFCore.git

namespace School
{
    public class CoursePoco
    {
        [Key]
        public int Id { get; set; } //Should be composite key
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public TeacherPoco Teacher { get; set; }    
    }
}


//docs.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key