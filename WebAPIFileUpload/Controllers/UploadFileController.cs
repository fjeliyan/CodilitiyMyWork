using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPIFileUpload.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class UploadFileController : Controller
    {
       
      
           
        // POST 
        // IFormFile is space of the Microsoft.AspNetCore.Http
        // CancellationToken is space of the System.Threading.
        [HttpPost("upload", Name = "upload")]
        [ProducesResponseType(StatusCodes.Status200OK)] // if response is okey, it wil response Status200 
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)] // if response is not okey, it wil response 400 BadRequest 
        public async Task<IActionResult> UploadFile(IFormFile file, CancellationToken cancellationToken)
        {
            if (CheckIfExcelFile(file))
            {
                await WriteFile(file);
            }
            else {
                return BadRequest(new { message = "Invalid file extension" });
            
            }
            return Ok();
        }

        private async Task<bool> WriteFile(IFormFile file)
        {
            bool isSaveSuccess = false;
            string fileName;
            try
            { 
                var extension = "." + file.FileName.Split('.')[file.FileName.Split('.').Length - 1];
                fileName = DateTime.Now.Ticks + extension;// Create a new Name for the file due to security reasons. 

                var pathBuilt = Path.Combine(Directory.GetCurrentDirectory(), "Upload\\files");
               //Als pathBuilt niet bestaat, create dit path 
                if (!Directory.Exists(pathBuilt))
                {
                    Directory.CreateDirectory(pathBuilt);
                }
                var path = Path.Combine(pathBuilt, fileName );

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                isSaveSuccess = true;

           }catch (Exception e)
            {
                string message = e.Message;
               message.ToString();
            }

            return isSaveSuccess;
        }

        private bool CheckIfExcelFile(IFormFile file)
        {
            var extension = "." + file.FileName.Split('.')[file.FileName.Split('.').Length - 1];
            return (extension == ".xlsx" || extension == ".xls"); //Change the extension based on your need 
        }

       
    }
}
