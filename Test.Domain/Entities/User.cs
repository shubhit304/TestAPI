using System.ComponentModel.DataAnnotations;

namespace Test.Domain
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "User name is required")]
        [Display(Name = "User Name")]
        public string? UserName { get; set; }

        [Display(Name = "Email ID")]
        [DataType(DataType.EmailAddress, ErrorMessage ="Please enter valid email address")]
        public string? EmailID { get; set; }

        [Display(Name = "Mobile Number")]
        [Required(ErrorMessage = "Mobile Number is required")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Please enter valid mobile number")]
        public string? MobileNo { get; set; }

        [Display(Name ="User Type")]
        [Required(ErrorMessage = "User type is required")]
        public UserType UserType { get; set; }

        [Display(Name ="Created On")]
        public DateTime CreatedOn { get; set; }

        public UserStatus Status { get; set; }
    }

    public enum UserType
    {
        LipiAdmin,
        GITC,
        CorporateCenter,
        CircleAdmin,
        Circle,
        ChannelManagerSupervisor,
        ChannelManagerFacilitator
    }

    public enum UserStatus
    {
        Active,
        Inactive
    }
}