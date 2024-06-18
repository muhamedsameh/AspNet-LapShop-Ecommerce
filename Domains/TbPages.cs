using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class TbPages
    {
        public int PageId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string MetaKeyWord { get; set; } = null!;

        public string MetaDescription { get; set; } = null!;
        [ValidateNever]
        public string ImgName { get; set; } = null!;
        [ValidateNever]
        public int CurrentState { get; set; }
        public DateTime CreatedDate { get; set; }
        [ValidateNever]
        public string CreatedBy { get; set; } = null!;
        [ValidateNever]
        public DateTime? UpdatedDate { get; set; }
        [ValidateNever]
        public string? UpdatedBy { get; set; }

    }
}
