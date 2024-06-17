using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class TbSittings
    {
        [ValidateNever]
        public int Id { get; set; }

        [Required(ErrorMessage = "Website Name is required")]
        [StringLength(100, ErrorMessage = "Website Name cannot exceed 100 characters")]
        public string WebsiteName { get; set; }

        [ValidateNever]
        public string Logo { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
        public string Description { get; set; }

        [Url(ErrorMessage = "Please enter a valid Facebook URL")]
        public string FacebookLink { get; set; }

        [Url(ErrorMessage = "Please enter a valid Twitter (X) URL")]
        public string XLink { get; set; }

        [Url(ErrorMessage = "Please enter a valid Instagram URL")]
        public string InstaLink { get; set; }

        [Url(ErrorMessage = "Please enter a valid YouTube URL")]
        public string YoutubeLink { get; set; }

        [Url(ErrorMessage = "Please enter a valid LinkedIn URL")]
        public string LinkedinLink { get; set; }

        [StringLength(200, ErrorMessage = "Location cannot exceed 200 characters")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Please enter a valid phone number")]
        [StringLength(15, ErrorMessage = "Phone number cannot exceed 15 characters")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [ValidateNever]
        public string MiddlePanner { get; set; }

        [ValidateNever]
        public string LastPanner { get; set; }

        [ValidateNever]
        public string HomeBackgroundImgName { get; set; }

        [ValidateNever]
        public string UpdatedBy { get; set; }
        [ValidateNever]
        public DateTime UpdatedDate { get; set; }

    }
}
