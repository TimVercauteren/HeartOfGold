using BudgetMiner.Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace BudgetMiner.Api.Controllers
{
    public class ProfilesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}