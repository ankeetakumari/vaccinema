﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VaccineManagementSystem.Models;

public partial class UserTbl
{
    public int UserId { get; set; }

    [Required(ErrorMessage = "Username is required")]
    [MinLength(3, ErrorMessage = "Username must be at least 3 characters long")]
    public string UserName { get; set; }

    [Required(ErrorMessage = "Phone number is required")]
    [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be 10 digits")]
    public string PhoneNumber { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    public string EmailId { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [MinLength(6, ErrorMessage = "Password must be at least 6 characters long")]
    public byte[] Password { get; set; }


    [Required(ErrorMessage = "Aadhaar number is required")]
    [RegularExpression(@"^\d{12}$", ErrorMessage = "Aadhaar number must be 12 digits")]
    public string AadhaarNum { get; set; }

    [Required(ErrorMessage = "Date of Birth is required")]
    [DataType(DataType.Date)]
    public DateOnly Dob { get; set; }

    [Required(ErrorMessage = "Address is required")]
    [MinLength(5, ErrorMessage = "Address must be at least 5 characters long")]
    public string Address { get; set; }

    public string CaptchaResponse { get; set; }

    public virtual ICollection<FamilyMembersTbl> FamilyMembersTbls { get; set; } = new List<FamilyMembersTbl>();

    public virtual ICollection<FeedbackTbl> FeedbackTbls { get; set; } = new List<FeedbackTbl>();

    public virtual ICollection<VaccinationCertificate> VaccinationCertificates { get; set; } = new List<VaccinationCertificate>();

    public virtual ICollection<VaccineHistory> VaccineHistories { get; set; } = new List<VaccineHistory>();

    public virtual ICollection<VaccineSlotsTbl> VaccineSlotsTbls { get; set; } = new List<VaccineSlotsTbl>();
}