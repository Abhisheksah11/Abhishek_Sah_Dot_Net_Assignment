using System.ComponentModel.DataAnnotations;

namespace Abhishek_Sah_Dot_Net_Assignment.Models
{
    public class Employee
    {
        [Key] // Marks EmployeeId as the primary key
        public int EmployeeId { get; set; }

        
        [StringLength(100)] // Limits Name length to 100 characters
        public required string Name { get; set; }

     
        public required string Position { get; set; }

   
        [Range(3000, 1000000)] // Restricts salary within a valid range
        public required decimal Salary { get; set; }
    }
}
