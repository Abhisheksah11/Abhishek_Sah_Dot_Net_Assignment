namespace Abhishek_Sah_Dot_Net_Assignment.Models
{
    public class RequestJob
    {
        public int Id { get; set; }  // Unique identifier for the job request

        public int EmployeeId { get; set; }  // Foreign key to link the request to an employee

        public string JobTitle { get; set; }  // Job title requested by the employee

        public DateTime RequestedDate { get; set; }  // The date when the request was made

        public string Remarks { get; set; }  // Additional remarks or status about the request
    }
}
