using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cw11.DTOs;
using Cw11.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cw11.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly DoctorDbService _doctorDbService;

        public DoctorsController(DoctorDbService doctorDbService)
        {
            _doctorDbService = doctorDbService;
        }

        [HttpGet]
        public IActionResult GetDoctors()
        {
            return Ok(_doctorDbService.GetDoctors());
        }

        [HttpPost]
        public IActionResult CreateDoctor(DoctorDTO doctorDto)
        {
            var doctor = _doctorDbService.AddDoctor(doctorDto);

            return Created("", doctor);
        }

        [HttpPut("{doctorId}")]
        public IActionResult UpdateDoctor(int doctorId, DoctorDTO doctorDto)
        {
            _doctorDbService.UpdateDoctor(doctorId, doctorDto);

            return Ok();
        }

        [HttpDelete("{doctorId}")]
        public IActionResult DeleteDoctor(int doctorId)
        {
            _doctorDbService.DeleteDoctor(doctorId);

            return Ok();
        }
    }
}