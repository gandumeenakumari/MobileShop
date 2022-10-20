using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MobileShop.Data;
using MobileShop.Core;

namespace MobileShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileController : ControllerBase
    {
        private readonly MobileDbContext _mobileDbContext;
        private Core.Bll bll;
        public MobileController()
        {
            bll = new Bll();
        }
        [HttpGet]
        [Route("Read")]
        public List<Mobile> GetMobiles()
        {
            return bll.GetMobiles();
        }
        [HttpPost]
        [Route("Post")]
        public void PostMobile([FromBody] Mobile mobile)
        {
            bll.PostMobile(mobile);
        }
        [HttpDelete]
        [Route("Delete")]
        public void DeleteMobile(int MobileId)
        {
            bll.DeleteMobile(MobileId);
        }
        //public MobileController(MobileDbContext mobileDbContext)
        //{
        //    _mobileDbContext = mobileDbContext;
        //}
        //[HttpGet]
        //public async Task<IActionResult> GetAllMobiles()
        //{
        //    var mobiles = await _mobileDbContext.Mobiles.ToListAsync();
        //    return Ok(mobiles);
        //}
        //[HttpPost]
        //public async Task<IActionResult> AddMobile([FromBody] Mobile mobileRequest)
        //{
        //    await _mobileDbContext.Mobiles.AddAsync(mobileRequest);
        //    await _mobileDbContext.SaveChangesAsync();
        //    return Ok(mobileRequest);
        //}
        //[HttpPut]
        //[Route("{MobileId}")]
        //public async Task<IActionResult> UpdateMobile([FromRoute] int MobileId,Mobile updatemobile)
        //{
        //    var mobile=await _mobileDbContext.Mobiles.FindAsync(MobileId);
        //    if(mobile==null)
        //    {
        //        return NotFound();
        //    }
        //    mobile.RAM = updatemobile.RAM;
        //    mobile.Model = updatemobile.Model;
        //    mobile.Cost = updatemobile.Cost;
        //    await _mobileDbContext.SaveChangesAsync();
        //    return Ok(mobile);
        //}
        //[HttpDelete]
        //[Route("{MobileId}")]
        //public async Task<IActionResult> DeleteMobile([FromRoute] int MobileId)
        //{
        //    var mobile=await _mobileDbContext.Mobiles.FindAsync(MobileId);
        //    if(mobile==null)
        //    {
        //        return NotFound();
        //    }
        //    _mobileDbContext.Mobiles.Remove(mobile);
        //    await _mobileDbContext.SaveChangesAsync();
        //    return Ok(mobile);
        //}
    }

}
