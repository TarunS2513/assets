using AssetManagementSystem.Models;
using AssetManagementSystem.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetsController : ControllerBase
    {
        private readonly IAssetService _service;
        public AssetsController(IAssetService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Asset> assets = _service.GetAllAsset();
            return Ok(assets);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetAssetById(int id)
        {
            Asset asset = _service.GetAssetById(id);
            return Ok(asset);
        }
        [HttpPost]
        public IActionResult Post( Asset asset)
        {
            int Result = _service.AddNewAsset(asset);
            return Ok(Result);
        }
        [HttpPut]
        public IActionResult Put(Asset asset)
        {
            string result = _service.UpdateAsset(asset);
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            string result = _service.DeleteAsset(id);
            return Ok(result);
        }
    }
}
