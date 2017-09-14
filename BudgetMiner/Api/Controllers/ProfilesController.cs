using BudgetMiner.Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace BudgetMiner.Api.Controllers
{
    public class ProfilesController : Controller
    {
        [HttpGet]
        public IActionResult Get(int id)
        {
            //Reader logic here, mocking for now

            //Replace mock 
            var mock = new ProfileCostModel()
            {
                FunctionDescription = "Beschrijving functie",
                AnnualIncrease = 0.3m,
                BaseJunior = 2000,
                BaseMedior = 2500,
                BaseSenior = 3000,
                FunctionTitle = "Titel Functie",
                InstructionsHTML = new HtmlInstructionsViewModel()
                {
                    Content = "<p>HTML Testcontent</p>"
                }
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