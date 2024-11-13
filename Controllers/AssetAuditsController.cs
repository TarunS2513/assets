using AssetManagementSystem.Models;
using AssetManagementSystem.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetAuditsController : ControllerBase
    {
        private readonly IAssetAuditService _service;
        public AssetAuditsController(IAssetAuditService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAllAssetAudit()
        {
            List<AssetAudit> assetaudit = _service.GetAllAssetAudits();
            return Ok(assetaudit);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetAssetAuditById(int id)
        {
            AssetAudit assetaudit = _service.GetAssetAuditById(id);
            return Ok(assetaudit);
        }
        [HttpPost]
        public IActionResult Post(AssetAudit assetaudit)
        {
            int Result = _service.AddNewAssetAudit(assetaudit);
            return Ok(Result);
        }
        [HttpPut]
        public IActionResult Put(AssetAudit assetaudit)
        {
            string result = _service.UpdateAssetAudit(assetaudit);
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            string result = _service.DeleteAssetAudit(id);
            return Ok(result);
        }
    }
}
