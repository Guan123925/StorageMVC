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
        
        public ActionResult LoginShows()
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

        public int UserLogins(string name = "", int Id = 0)
        {
            if (name != null)
            {
                Session["name"] = name;
                Session["Id"] = Id;
                return 1;
            }
            return 0;
        }
        /// <summary>
        /// 图片验证
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public int TuPianYanZheng(string token)
        {
            String appId = "f4821addb462dd54853153c0c72ef42f";
            String appSecret = "4a1b54464e6af3cb0ceb4bda7816cf32";
            DxCsharpSDK.Captcha captcha = new DxCsharpSDK.Captcha(appId, appSecret);//DxCsharpSDK 为引用 DxCsharpSDK.dll
            DxCsharpSDK.CaptchaResponse response = captcha.VerifyToken(token);
            Response.Write(response.captchaStatus);
            //确保验证状态是SERVER_SUCCESS，SDK中有容错机制，在网络出现异常的情况会返回通过
            if (response.result)
            {
                /**token验证通过，继续其他流程**/
                return 1;
            }
            else
            {
                /**token验证失败，业务系统可以直接阻断该次请求或者继续弹验证码**/
                return 0;
            }
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
        public ActionResult RegistShow()
        {
            return View();
        }
    }
}