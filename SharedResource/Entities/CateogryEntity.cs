using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedResource.Entities
{
    public class CategoryEntity
    {
        public string? Category { get; set; }
        public ImageURL Thumbnail { get; set; } = new();
        public StatusAtive Status { get; set; }
    }
    //Update MinIO
    public class ImageURL
    {
        public string? Domain { get; set; }
        public string? Bucket { get; set; }
        public string? FileName { get; set; }
        public int Priority { get; set; } = 0;
    }
    public enum StatusAtive
    {
        Activate,
        Deactivate
    }
}
