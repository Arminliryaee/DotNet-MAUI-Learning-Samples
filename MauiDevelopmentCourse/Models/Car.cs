namespace MauiDevelopmentCourse.Models
{
    public class Car : BaseEntity
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
