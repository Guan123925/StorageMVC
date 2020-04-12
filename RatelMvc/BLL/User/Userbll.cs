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
            return ApiRequestHelp.Post<UserLoginRequest, UserLoginResponse>(request);
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

        /// <summary>
        /// 部门
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DepartmentInfoGetResponse DepartmentInfoGet(DepartmentInfoGetRequest request)
        {
            return ApiRequestHelp.Post<DepartmentInfoGetRequest, DepartmentInfoGetResponse>(request);
        }
        /// <summary>
        /// 职位
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public PositionInfoGetResponse PositionInfoGet(PositionInfoGetRequest request)
        {
            return ApiRequestHelp.Post<PositionInfoGetRequest, PositionInfoGetResponse>(request);
        }
        /// <summary>
        /// 员工
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public StaffInfoGetResponse StaffInfoGet(StaffInfoGetRequset request)
        {
            return ApiRequestHelp.Post<StaffInfoGetRequset, StaffInfoGetResponse>(request);
        }
    }
}
