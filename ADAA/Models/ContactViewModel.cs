using ADAA.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ADAA.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessageResourceType = typeof (Validation), ErrorMessageResourceName = "RequiredErrorMessage")]
        [DataType(DataType.Text)]
        [Display(ResourceType = typeof (Validation), Name = "CountryDisplayName")]
        public string Country { get; set; }

        [Required(ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "RequiredErrorMessage")]
        [StringLength(5, ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "CityMaxLengthError")]
        [DataType(DataType.Text)]
        [Display(ResourceType = typeof(Validation), Name = "CityDisplayName")]
        public string City { get; set; }

        [Required(ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "RequiredErrorMessage")]
        [StringLength(5, MinimumLength = 1, ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "NameMaxLengthError")]
        [DataType(DataType.Text)]
        [Display(ResourceType = typeof(Validation), Name = "NameDisplayName")]
        public string Name { get; set; }

        [Required(ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "RequiredErrorMessage")]
        [MaxLength(5, ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "EmailMaxLengthError")]
        [DataType(DataType.EmailAddress, ErrorMessageResourceName = "EmailDataTypeError", ErrorMessageResourceType = typeof(Validation))]
        [Display(ResourceType = typeof(Validation), Name = "EmailDisplayName")]
        public string Email { get; set; }

        [MaxLength(20, ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "PhoneMaxLengthError")]
        [DataType(DataType.PhoneNumber, ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "PhoneDataTypeError")]
        [Display(ResourceType = typeof(Validation), Name = "PhoneDisplayName")]
        public string Phone { get; set; }

        [Required(ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "RequiredErrorMessage", ErrorMessage = null)]
        [DataType(DataType.MultilineText)]
        [Display(ResourceType = typeof(Validation), Name = "MessageDisplayName")]
        public string Message { get; set; }
    }
}