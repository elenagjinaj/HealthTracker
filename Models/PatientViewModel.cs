using HealthTracker.Data.Entities;

namespace HealthTracker.Models
{
    public class PatientViewModel
    {
        public int PatientId { get; set; }

        public string PatientFname { get; set; } = null!;

        public string PatientLname { get; set; } = null!;

        public DateOnly PatientDob { get; set; }

        public string Gender { get; set; } = null!;

        public string? ContactNumber { get; set; }

        public string? Address { get; set; }

    }
}
