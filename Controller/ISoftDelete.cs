//github.com/johnhinz/InClassJuly25EFCore.git

namespace School
{
    public interface ISoftDelete
    {
        public bool IsDeleted { get; set; }
    }
}


//docs.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key