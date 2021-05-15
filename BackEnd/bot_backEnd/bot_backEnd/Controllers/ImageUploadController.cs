using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using bot_backEnd.Data;
using bot_backEnd.Models;
using bot_backEnd.UI.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bot_be.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageUploadController : ControllerBase
    {
        public static IWebHostEnvironment _environment;
        private readonly IPostImageUI _iUploadImageUI;
        private readonly AppDbContext _context;

        public ImageUploadController(IWebHostEnvironment enviroment, IPostImageUI iUploadImageUI, AppDbContext context)
        {
            _environment = enviroment;
            _iUploadImageUI = iUploadImageUI;
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult GetImagesByPostID(int id)
        {
            return Ok(_iUploadImageUI.GetImagesByPostID(id));
        }

        //[HttpPost("newPhoto")]
        //public async Task<IActionResult> PostImages([FromForm(Name = "file")]IFormFile[] fileObj, int PostID, int typeID) //type: 1? "postPhotos" : "profilePhoto";
        //{
        //    int subFolderID; //number of subFolder
        //    string subFolder; //name of subfolder with ID on the END
        //    int maxID;

        //    if (fileObj == null || fileObj.Length == 0)
        //        return BadRequest("Please select atleast one image file");

        //    string folder = "/post/";

        //    if (!Directory.Exists(_environment.WebRootPath + folder))
        //        Directory.CreateDirectory(_environment.WebRootPath + folder);

        //    foreach (IFormFile img in fileObj) //foreach sent image
        //    {
        //        string imgext = Path.GetExtension(img.FileName);
        //        maxID = _context.Image.Count() > 0 ? _context.Image.Max(i => i.Id) + 1 : 1;

        //        if (imgext == ".jpg" || imgext == ".png" || imgext == ".jpeg")
        //        {
        //            subFolderID = maxID / 3000 + 1;
        //            subFolder = string.Format("{0:D4}", subFolderID) +"/";

        //            EntityImage newImage = new EntityImage
        //            {
        //                Id = maxID,
        //                PostID = PostID,
        //                TypeID = typeID,
        //                Path = folder + subFolder,
        //                Name = img.FileName
        //            };

        //            _iUploadImageUI.addImage(newImage);

        //            if (!Directory.Exists(_environment.WebRootPath + folder + subFolder))
        //                Directory.CreateDirectory(_environment.WebRootPath + folder + subFolder);

        //            using FileStream fileStream = System.IO.File.Create(_environment.WebRootPath + folder + subFolder + img.FileName);
        //            await img.CopyToAsync(fileStream);
        //            fileStream.Flush();
        //        }
        //        else
        //        {
        //            return BadRequest("Please upload only the .jpg && .png image files");
        //        }
        //    }
        //    return Ok();
        //}
    }
}