﻿using Microsoft.AspNetCore.Mvc;
using OralData.Backend.Interfaces;
using OralData.Shared.Entities;

namespace OralData.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : GenericController<Country>
    {
        public CountriesController(IGenericUnitOfWork<Country> unitOfWork) : base(unitOfWork)
        {
        }
    }
}