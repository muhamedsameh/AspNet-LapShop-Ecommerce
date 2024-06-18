using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LapShop.Models;

public partial class TbSlider
{
    [ValidateNever]
    public int SliderId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }
    [ValidateNever]
    public string ImageName { get; set; } = null!;

    public int CurrentState { get; set; }
    [ValidateNever]
    public DateTime CreatedDate { get; set; }
    [ValidateNever]
    public string CreatedBy { get; set; } = null!;
    [ValidateNever]
    public DateTime? UpdatedDate { get; set; }
    [ValidateNever]
    public string? UpdatedBy { get; set; }
}
