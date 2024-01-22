using HealthTracker.Data.Entities;

namespace HealthTracker.Models
{
    public class DoctorViewModel
    {
        public int? DoctorId { get; set; }
        public string? DepartmentName { get; set; }

        public string DocFname { get; set; } = null!;

        public string DocLname { get; set; } = null!;

        public string DocGender { get; set; } = null!;

        public string Specalization { get; set; } = null!;
    }
}
