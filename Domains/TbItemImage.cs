using System;
using System.Collections.Generic;

namespace LapShop.Models;

public partial class TbItemImage
{
    public int ImageId { get; set; }

    public string ImageName { get; set; } = null!;

    public int ItemId { get; set; }

    public virtual TbItem Item { get; set; } = null!;
}
