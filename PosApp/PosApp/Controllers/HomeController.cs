using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PosApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace PosApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        private List<MerchantDetails> GetMerchantDetails()
        {
            List<MerchantDetails> merchantDetails = new List<MerchantDetails>();
            merchantDetails.Add(new MerchantDetails { Address = "abcd", MerchantId = 1, Name = "asdd", TerminalId = "assddd" });
            return merchantDetails;
        }
        
        public IActionResult Index()
        {
            MerchantDetails mymodel = new MerchantDetails();

            mymodel chantDetails();
            return View(mymodel);
            
        }

        public PartialViewResult RenderMerchantDetails ()
        {
            MerchantDetails merchantDetails = new MerchantDetails
            {
                Address = "adad",
                MerchantId = 1,
                Name ="aaddad",
                TerminalId ="sfdfdf",
              
            };
            return PartialView(merchantDetails);
        }
        [HttpGet]
        public PartialViewResult RenderPurchaseDetails()
        {
            return PartialView();
        }

        public PartialViewResult RenderCardDetails()
        {
            return PartialView();
        }

        public PartialViewResult RenderTransactionDetails()
        {
            return PartialView();
        }

      
        public IActionResult Privacy()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
