using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BudgetMiner.Business.Models.EmployeeCost;

namespace BudgetMiner.Api.Controllers
{
    public class ProfilesController : Controller
    {
        [HttpGet]
        public IActionResult Get(int id)
        {
            //Reader logic here, mocking for now

            //replace mock 
            var mock = new ProfileCostModel()
            {
                FunctionDescription = "Beschrijving functie",
                AnnualIncrease = 0.3m,
                BaseJunior = 2000,
                BaseMedior = 2500,
                BaseSenior = 3000,
                FunctionTitle = "Titel Functie",
                InstructionsHTML = "<p>De instructies</p>"
            };

            return Ok(mock);
        }

        [HttpPost]
        public IActionResult Post([FromBody] ProfileCostModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(model);
            }

            //MAP MODEL
            var modelMapper = model; 

            //Write model to DB

            return Ok(model);
        }

        [HttpPut]
        public IActionResult Put([FromBody] ProfileCostModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(model);
            }

            //MAP MODEL
            var modelMapper = model;

            //Write to DB & Validate

            return Ok(model);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}