using AssetManagementSystem.Models;
using AssetManagementSystem.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetBorrowingsController : ControllerBase
    {
        private readonly IAssetBorrowingService _service;
        public AssetBorrowingsController(IAssetBorrowingService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAllAssetBorrowing()
        {
            List<AssetBorrowing> assetborrowing = _service.GetAllAssetBorrowing();
            return Ok(assetborrowing);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetAssetBorrowingById(int id)
        {
            AssetBorrowing assetborrowing = _service.GetAssetBorrowingById(id);
            return Ok(assetborrowing);
        }
        [HttpPost]
        public IActionResult Post(AssetBorrowing assetborrowing)
        {
            int Result = _service.AddNewAssetBorrowing(assetborrowing);
            return Ok(Result);
        }
        [HttpPut]
        public IActionResult Put(AssetBorrowing assetborrowing)
        {
            string result = _service.UpdateAssetBorrowing(assetborrowing);
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            string result = _service.DeleteAssetBorrowing(id);
            return Ok(result);
        }
    }
}
