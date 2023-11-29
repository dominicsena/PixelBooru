using Microsoft.AspNetCore.Mvc;
using pixelBooru.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class ArtworkController : Controller
{
    public IActionResult Index()
    {
        var imageDirectory = "wwwroot/testImages";
        var imageFiles = Directory.EnumerateFiles(imageDirectory, "*.*").Where(s => s.EndsWith(".jpg") || s.EndsWith(".png") || s.EndsWith(".gif") || s.EndsWith(".bmp") || s.EndsWith(".jpeg")).ToList();

        var pageSize = 60;
        var page = HttpContext.Request.Query["page"].Count > 0 ? int.Parse(HttpContext.Request.Query["page"]) : 1; // Define page here
        var totalCombinedPages = Math.Ceiling((double)imageFiles.Count / pageSize);
        var combinedOffset = (page - 1) * pageSize;
        var currentPageResults = imageFiles.Skip(combinedOffset).Take(pageSize);

        var imageModels = currentPageResults.Select(imagePath => new ImageModel 
        {
            ImagePath = imagePath,
            Title = "Title", // Add your logic to get title
            ArtistName = "Artist Name" // Add your logic to get artist name
        }).ToList();

        return View(imageModels);
    }
}
