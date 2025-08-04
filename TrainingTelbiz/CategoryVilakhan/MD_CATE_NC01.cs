using CategoryServices.Repository;
using Couchbase.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SharedResource.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTelbiz.CategoryVilakhan
{
    public class MD_CATE_NC01
    {
        ICategoryRepo categoryRepo;
        public MD_CATE_NC01()
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder();
            ServiceProvider serviceProvider = builder.Services.AddCouchbase(client =>
            {
                client.ConnectionString = "couchbase://127.0.0.1";
                client.UserName = "Administrator";
                client.Password = "1qaz2wsx";
            }).BuildServiceProvider();
            var bucketProvider = serviceProvider.GetService<IBucketProvider>();
            categoryRepo = new CategoryRepo(bucketProvider, default);
        }


        [Fact(DisplayName = "ສະແດງໝວດອາຫານເຄື່ອງດື່ມທັງໝົດ")]
        public void P01()
        {
            Assert.True(false);
        }

        [Fact(DisplayName = "ສະແດງໝວດອາຫານເຄື່ອງດື່ມຕາມສະຖານະ (1: Activate, 0: Deactivate)")]
        public void P02()
        {
            Assert.True(false);
        }
        [Fact(DisplayName = "ສະແດງໝວດອາຫານເຄື່ອງດື່ມຕາມ ID")]
        public void P03()
        {
            Assert.True(false);
        }
        [Fact(DisplayName = "ເພີ່ມ ໝວດອາຫານເຄື່ອງດື່ມ")]
        public async void P04()
        {
            var request = new CategoryDTOs()
            {
                ID = Guid.NewGuid().ToString("N"),
                Category = "ປະເພດເຄື່ອງດື່ມ",
                Status = SharedResource.Entities.StatusAtive.Activate,
                Thumbnail = new SharedResource.Entities.ImageURL()
                {
                    Bucket = "",
                    Domain = "",
                    FileName = "",
                    Priority = 1
                }
            };

            var result = await categoryRepo.Save(request);
            Assert.True(result);


        }
        [Fact(DisplayName = "ແກ້ໄຂ ໝວດອາຫານເຄື່ອງດື່ມ")]
        public void P05()
        {
            Assert.True(false);
        }
        [Fact(DisplayName = "ລຶບ ໝວດອາຫານເຄື່ອງດື່ມ")]
        public void P06()
        {
            Assert.True(false);
        }
    }
}
