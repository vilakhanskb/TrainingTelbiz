using Couchbase.Core.Retry;
using Couchbase.Extensions.DependencyInjection;
using SharedResource.Config;
using SharedResource.DTOs;
using SharedResource.Entities;
using System.Security.Cryptography.X509Certificates;

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

        public async Task<bool> Save(CategoryDTOs request)
        {
            try
            {
                var bucket = await bucketProvider.GetBucketAsync(DBConfig.bucket);
                var scope = await bucket.ScopeAsync(DBConfig.scope);

                var collection = await scope.CollectionAsync(DBCollection.category);
                await collection.InsertAsync(request.ID!, request);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


    }
}
