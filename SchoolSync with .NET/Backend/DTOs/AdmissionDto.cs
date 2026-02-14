using System.ComponentModel.DataAnnotations;

namespace SmartSchoolAPI.DTOs;

public class AdmissionDto
{
    public int? AdmissionId { get; set; }

    [Required(ErrorMessage = "First name is required")]
    [MaxLength(100, ErrorMessage = "First name cannot exceed 100 characters")]
    public string FirstName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Last name is required")]
    [MaxLength(100, ErrorMessage = "Last name cannot exceed 100 characters")]
    public string LastName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Date of birth is required")]
    public DateTime DateOfBirth { get; set; }

    [Required(ErrorMessage = "Gender is required")]
    public string Gender { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email format")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Phone is required")]
    [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Phone must be 10 digits")]
    public string Phone { get; set; } = string.Empty;

    [Required(ErrorMessage = "Address is required")]
    public string Address { get; set; } = string.Empty;

    [Required(ErrorMessage = "City is required")]
    public string City { get; set; } = string.Empty;

    [Required(ErrorMessage = "State is required")]
    public string State { get; set; } = string.Empty;

    [Required(ErrorMessage = "Pincode is required")]
    [RegularExpression(@"^[0-9]{6}$", ErrorMessage = "Pincode must be 6 digits")]
    public string Pincode { get; set; } = string.Empty;

    [Required(ErrorMessage = "Applied class is required")]
    public string AppliedClass { get; set; } = string.Empty;

    [Required(ErrorMessage = "Academic year is required")]
    public string AcademicYear { get; set; } = string.Empty;
    
    // Parent/Guardian Information
    [Required(ErrorMessage = "Father name is required")]
    public string FatherName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Father occupation is required")]
    public string FatherOccupation { get; set; } = string.Empty;

    [Required(ErrorMessage = "Father phone is required")]
    [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Father phone must be 10 digits")]
    public string FatherPhone { get; set; } = string.Empty;

    [Required(ErrorMessage = "Mother name is required")]
    public string MotherName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Mother occupation is required")]
    public string MotherOccupation { get; set; } = string.Empty;

    [Required(ErrorMessage = "Mother phone is required")]
    [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Mother phone must be 10 digits")]
    public string MotherPhone { get; set; } = string.Empty;

    public string GuardianName { get; set; } = string.Empty;
    public string GuardianRelation { get; set; } = string.Empty;

    [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Guardian phone must be 10 digits")]
    public string GuardianPhone { get; set; } = string.Empty;
    
    // Previous School Information
    public string? PreviousSchool { get; set; }
    public string? PreviousClass { get; set; }

    [Range(0, 100, ErrorMessage = "Previous marks must be between 0 and 100")]
    public decimal? PreviousMarks { get; set; }
    
    // Application Details
    public string Status { get; set; } = "Pending";
    public string? Remarks { get; set; }
    
    // Documents
    public string? PhotoUrl { get; set; }
    public string? BirthCertificateUrl { get; set; }
    public string? PreviousMarksheetUrl { get; set; }
    public string? AddressProofUrl { get; set; }
}
