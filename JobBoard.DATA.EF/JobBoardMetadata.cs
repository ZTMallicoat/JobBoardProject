using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JobBoard.DATA.EF
{
    [MetadataType(typeof(UserDetailsMetadata))]
    public partial class UserDetail
    {
        public class UserDetailsMetadata
        {
            [StringLength(128, ErrorMessage = "User Id must be 128 characters or less")]
            [Required(ErrorMessage = "Field is Required.")]
            [Display(Name = "User ID")]
            public string UserId { get; set; }
            [StringLength(50, ErrorMessage = "First name must be 50 characters or less.")]
            [Required(ErrorMessage = "Field is Required.")]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }
            [StringLength(50, ErrorMessage = "Last name must be 50 characters or less.")]
            [Required(ErrorMessage = "Field is Required.")]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }
        }
    }
    [MetadataType(typeof(PositionsMetadata))]
    public partial class Position
    {
        public class PositionsMetadata
        {
            [Display(Name = "Position ID")]
            public int PositionId { get; set; }
            [StringLength(50, ErrorMessage = "Job title must be 50 characters or less.")]
            [Required(ErrorMessage = "Field is Required.")]
            public string Title { get; set; }
            [Display(Name = "Job Description")]
            public string JobDescription { get; set; }
        }
    }
    [MetadataType(typeof(LocationsMetadata))]
    public partial class Location
    {
        public class LocationsMetadata
        {
            [Display(Name = "Location ID")]
            public int LocationId { get; set; }
            [StringLength(10, ErrorMessage = "Store number must be 10 characters or less")]
            [Required(ErrorMessage = "Field is Required.")]
            [Display(Name = "Store Number")]
            public string StoreNumber { get; set; }
            [StringLength(50, ErrorMessage = "First name must be 50 characters or less.")]
            [Required(ErrorMessage = "Field is Required.")]
            public string City { get; set; }
            [StringLength(2, ErrorMessage = "State must be 2 characters.")]
            [Required(ErrorMessage = "Field is Required.")]
            public string State { get; set; }
        }
    }
    [MetadataType(typeof(ApplicationsMetadata))]
    public partial class Application
    {
        public class ApplicationsMetadata
        {
            [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
            public DateTime ApplicationDate { get; set; }
            [Display(Name = "Application ID")]
            public int ApplicationId { get; set; }
            [Display(Name = "Open Position ID")]
            public int OpenPositionId { get; set; }
            [StringLength(200, ErrorMessage = "Notes must be 200 characters or less.")]
            [Display(Name = "Managers' Notes")]
            public string ManagerNotes { get; set; }
            [StringLength(75, ErrorMessage = "File path must be 75 characters or less.")]
            [Display(Name = "Resume File")]
            public string ResumeFileName { get; set; }
        }
    }
    [MetadataType(typeof(ApplicationStatusMetadata))]
    public partial class ApplicationStatu
    {
        public class ApplicationStatusMetadata
        {
            [Display(Name ="Application Status ID")]
            public int ApplicationStatusId { get; set; }
            [StringLength(50, ErrorMessage = "Status must be 50 characters or less.")]
            [Required(ErrorMessage = "Field is Required.")]
            [Display(Name = "Status")]
            public string StatusName { get; set; }
            [StringLength(250, ErrorMessage = "Description must be 75 characters or less.")]
            [Display(Name = "Status Description")]
            public string StatusDescription { get; set; }
        }
    }
}
