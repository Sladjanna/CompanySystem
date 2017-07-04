using Model;
using Services;
using Services.Services;
using System.Web.Mvc;
using WebUI.Models;
using System;

namespace WebUI.Controllers
{
    public class AccountController : Controller
    {
        private AccountService _accountService;
        private DepartmentServices _departmentService = new DepartmentServices();

        public AccountController()
        {
            _accountService = new AccountService();
            _departmentService = new DepartmentServices();
        }

        //------------------LOG IN postojece usera------------------------------------------
        // GET: method
        public ActionResult Login()
        {
            return View();    //LOG IN page
        }

        //POST: method
        [HttpPost]
        public ActionResult LogIn(LoginModel logInData)
        {
            if (!ModelState.IsValid)
            {
                return View("Login", logInData);     //LOG IN page
            }

            var result = _accountService.LogIn(logInData.UserName, logInData.Password);
            if (result)
            {
                return View("Hello");
            }
            return View("Login");   //NOT Succesffully , return again to log in page
        }

        //---------------------CREATE NEW USER-------------------------------------------
        [HttpGet]
        public ActionResult Create()
        {
            return View();  //CREATE new user page
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            // var dep = _departmentService.GetDepartmentByID(user.DepartmentID);
           var newUser = _accountService.InsertUser(user.UserName, user.Password, user.FirstName, user.LastName, user.Gender, user.Birthday, user.DepartmentID);
            if (newUser != null)
            {
                return RedirectToAction("LogIn", "Account");
            }
            return View("Create");
        }

    }
}