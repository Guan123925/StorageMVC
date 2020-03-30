using SDKClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public  class Userbll
    {
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UserLoginResponse UserLogin(UserLoginRequest request)
        {
            return 
        }
        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UserRegistReponse UserRegist(UserRegistRequest request)
        {
            return ApiRequestHelp.Post<UserRegistRequest,UserRegistReponse>(request);
        }
    }
}
