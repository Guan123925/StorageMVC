using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using SDKClient;

namespace RatelMvc.Controllers
{
    public class UsersController : Controller
    {
        Userbll bll = new Userbll();
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public JsonResult UserLogin(UserLoginRequest request)
        {
            return Json(bll.UserLogin(request));
        }
        public ActionResult LoginShow()
        {
            return View();
        }
        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public JsonResult UserRegist(UserRegistRequest request)
        {
            return Json(bll.UserRegist(request));
        }
    }
}