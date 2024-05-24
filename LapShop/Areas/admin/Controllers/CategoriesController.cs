using System;
using System.Collections.Generic;
using System.Linq;
using LapShop.Bl;
using LapShop.Models;
using LapShop.Utlities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LapShop.Areas.admin.Controllers;

[Authorize(Roles = "Admin")]
[Area("admin")]
public class CategoriesController : Controller
{
    ICategories oClsCategories;
    public CategoriesController(ICategories category)
    {
        oClsCategories = category;
    }

    public IActionResult List()
    {
        return View(oClsCategories.GetAll());
    }

    public IActionResult Edit(int? categoryId)
    {
        var category = new TbCategory();

        if (categoryId != null)
            category = oClsCategories.GetByID(Convert.ToInt32(categoryId));

        return View(category);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Save(TbCategory category, List<IFormFile> Files)
    {
        if (!base.ModelState.IsValid)
        {
            return View("Edit", category);
        }

        category.ImageName = await Helper.UploadImage(Files, "Categories");
        oClsCategories.Save(category);

        return RedirectToAction("Edit");
    }



    public IActionResult Delete(int? categoryId)
    {
        oClsCategories.Delete(Convert.ToInt32(categoryId));
        return RedirectToAction("List");
    }
}
