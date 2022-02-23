using Business;
using Common.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DistrictController : ControllerBase
    {
        private IDistrictService _districtService;
        public DistrictController(IDistrictService districtService)
        {
            _districtService = districtService;
        }
        [HttpGet]
        public IEnumerable<District> GetAll()
        {
            return _districtService.GetAll();
        }

        [HttpGet("{id}", Name = "GetDistrict")]
        public District GetById(int id)
        {
            return _districtService.GetById(id);
        }

        [HttpPost]
        public void Create(District district)
        {
            _districtService.Create(district);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _districtService.Delete(id);
        }

        [HttpPut("{id}")]
        public void Update(int id, District district)
        {
            _districtService.Update(id, district);
        }
    }
}