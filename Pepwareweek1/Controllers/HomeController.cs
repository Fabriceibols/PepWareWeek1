using Newtonsoft.Json;
using PepWareWeek1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PepWareWeek1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


            public ActionResult BasicCupcakes()
            {
            List<CakeModel> cake = new List<CakeModel>();
            
            var filePath = Server.MapPath("~/AppFiles/TextFiles/Basic.txt");
            var lines = System.IO.File.ReadAllLines(filePath);

            foreach (string row in lines)//lines.Split('\n')
            {
                if (!string.IsNullOrEmpty(row))
                {
                    cake.Add(new CakeModel
                    {

                        NumSold = Convert.ToInt32(row[0])
                        //TotSalAmt = row.Split(' ')[1],
                        //Day = row.Split(' ')[2]
                    });
                }
            }
            return View(cake);

            
            }

            public ActionResult DeluxeSales()
            {
            List<CakeModel> cake = new List<CakeModel>();
            
            var filePath = Server.MapPath("~/AppFiles/TextFiles/Delux.txt");

           
            //Read the contents of Text file.
            var lines = System.IO.File.ReadAllLines(filePath);

           
            ////Execute a loop over the rows.
            foreach (string row in lines)//lines.Split('\n')
            {
                if (!string.IsNullOrEmpty(row))
                {
                    cake.Add(new CakeModel
                    {

                        NumSold = Convert.ToInt32(row[0]),
                        Delux = Convert.ToInt32(row[0])
                        //Day = row.Split(' ')[2]
                    });
                }
            }
            return View(cake);
            //return View(1+1);
            }

        public ActionResult TotalSales()
        {


            List<CakeModel> cake = new List<CakeModel>();
            
            var filePath = Server.MapPath("~/AppFiles/TextFiles/Total.txt");

            
            
            //Read the contents of Text file.
            var lines = System.IO.File.ReadAllLines(filePath);

            
            foreach (string row in lines)//lines.Split('\n')
            {
                if (!string.IsNullOrEmpty(row))
                {
                    cake.Add(new CakeModel
                    {

                        NumSold = Convert.ToInt32(row[0]),
                        TotSalAmt = Convert.ToInt32(row[1])
                        //Day = row.Split(' ')[2]
                    });
                }
            }
            return View(cake);
        }
        public ActionResult WeeklySales()
        {
          

            return View(1+1);
        }

        public ActionResult MonthlySales()
        {
           

            return View(1+1);
        }

        public ActionResult AnnualSales()
        {
            

            return View(1+1);
        }
    }
}