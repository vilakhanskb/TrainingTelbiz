using Couchbase.Extensions.DependencyInjection;

namespace CategoryServices.Repository
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly IBucketProvider bucketProvider;
        private readonly ILogger<CategoryRepo> logger;

        public CategoryRepo(IBucketProvider bucketProvider, ILogger<CategoryRepo> logger)
        {
            this.bucketProvider = bucketProvider;
            this.logger = logger;
        }
    }
}
