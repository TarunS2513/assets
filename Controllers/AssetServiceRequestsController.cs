using AssetManagementSystem.Models;
using AssetManagementSystem.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetServiceRequestsController : ControllerBase
    {
        private readonly IAssetServiceRequestService _service;
        public AssetServiceRequestsController(IAssetServiceRequestService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            List<AssetServiceRequest> assetservicerequests = _service.GetAllAssetServiceRequest();
            return Ok(assetservicerequests);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetAssetServiceRequestById(int id)
        {
            AssetServiceRequest assetservicerequest = _service.GetAssetServiceRequestById(id);
            return Ok(assetservicerequest);
        }
        [HttpPost]
        public IActionResult Post(AssetServiceRequest assetservicerequest)
        {
            int Result = _service.AddNewAssetServiceRequest(assetservicerequest);
            return Ok(Result);
        }
        [HttpPut]
        public IActionResult Put(AssetServiceRequest assetServiceRequest)
        {
            string result = _service.UpdateAssetServiceRequest(assetServiceRequest);
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            string result = _service.DeleteAssetServiceRequest(id);
            return Ok(result);
        }
    }
}
