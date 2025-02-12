using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcMovie.Models;
namespace MvcMovie.Controllers{
    public class PersonController: Controller{
        [HttpGet]
        public IActionResult Create(){
        
            return View();
        }
        [HttpPost]
        public IActionResult Create(string Id, string FullName){
            string test = "Id: " + Id + " FullName: " + FullName;
            ViewBag.Message = test;
            return View();
        }
        public IActionResult Index(){
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person ps){
            string strOutput = "Xin chao " + ps.PersonId +"-"+ps.FullName+"-"+ps.Address;
            ViewBag.InfoPerson = strOutput;
            return View();
        }
    }
}