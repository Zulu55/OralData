﻿using Microsoft.AspNetCore.Mvc;
using OralData.Backend.UnitsOfWork;
using OralData.Shared.Entities;
using OralData.Backend.Interfaces;

namespace OralData.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : GenericController<Country>
    {
        public CountriesController(IGenericUnitOfWork<Country> unit) : base(unit)
        {
        }
    }
}


