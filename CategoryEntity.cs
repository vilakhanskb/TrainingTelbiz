using System;

public class CategoryEntity
{
    public string ID { get; set; }
    public string Category { get; set; }
    public ImageURL Thumbnail { get; set; }
    public CateStatus Status { get; set; }
}
//Update MinIO
public class ImageURL
{
    public string Domain { get; set; }
    public string Bucket { get; set; }
    public string FileName { get; set; }
    public int Priority { get; set; } = 0;
}
public enum CateStatus
{
    Activate,
    Deactivate
}
