﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CloudantDotNet.Models;
using CloudantDotNet.Services;

namespace CloudantDotNet.Controllers
{
    [Route("api/[controller]")]
    public class DbController : Controller
    {
        private readonly ICloudantService _cloudantService;

        public DbController(ICloudantService cloudantService)
        {
            _cloudantService = cloudantService;
        }

        [HttpPost]
        public async Task<dynamic> Create(VREntryItem item)
        {
            return await _cloudantService.CreateAsync(item);
        }

        [HttpGet]
        public async Task<dynamic> GetAll()
        {
            return await _cloudantService.GetAllAsync();
        }

        [HttpPut]
        public async Task<string> Update(VREntryItem item)
        {
            return await _cloudantService.UpdateAsync(item);
        }

        [HttpDelete]
        public async Task<dynamic> Delete(VREntryItem item)
        {
            return await _cloudantService.DeleteAsync(item);
        }
    }
}