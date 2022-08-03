using ASP.Net_Seminarski_rad.Services.Implementation;
using ASP.Net_Seminarski_rad.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Seminarski_rad.Controllers
{
    [Route("[controller]")]
    public class SharedController : Controller
    {
        private readonly IFileStorageService fileStorageService;

        public SharedController(IFileStorageService fileStorageService)
        {
            this.fileStorageService = fileStorageService;
        }

        [Route("files/{id}")]
        public async Task<IActionResult> GetFile(int id)
        {
            var img = await fileStorageService.GetFile(id);
            if (img == null)
            {
                return NoContent();
            }
            Response.Headers.Add("Content-Disposition", img.ContentDisposition.ToString());

            return File(img.FileStream, "image/" + img.FileExtension.Replace(".", string.Empty));
        }

        [HttpDelete]
        [Route("file/{id}")]
        public async Task<IActionResult> DeleteFile(int id)
        {
            if (await fileStorageService.DeleteFile(id))
            {
                return Ok(new { Msg = "deleted!" });
            }

            return BadRequest(new { Msg = "Error!" });
        }
    }
}
