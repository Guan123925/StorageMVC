using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDKClient;

namespace BLL
{
    public  class ProjectBll
    {
        /// <summary>
        /// 项目参与人员绑定
        /// 根据所在职位部门
        /// 加入单例
        /// </summary>
        public UserGetProjectResponse BandProjectbinding(UserGetProjectRequest request)
        {
            return ApiRequestHelp.Post<UserGetProjectRequest, UserGetProjectResponse>(request);
        }

        /// <summary>
        /// 新增项目
        /// </summary>
        public ProjectAddResponse AddProject(ProjectAddRequest request)
        {
            return ApiRequestHelp.Post<ProjectAddRequest, ProjectAddResponse>(request);
        }

        /// <summary>
        /// 修改项目
        /// </summary>
        /// <returns></returns>
        public ProjectUpdateResponse UpdateProject(ProjectUpdateRequest request)
        {
            return ApiRequestHelp.Post<ProjectUpdateRequest,ProjectUpdateResponse>(request);
        }

        /// <summary>
        /// 分页显示所有项目
        /// </summary>
        /// <returns></returns>
        public ProjectProcGetResponse ProjectShow(ProjectProcGetRequest request)
        {
            return ApiRequestHelp.Post<ProjectProcGetRequest, ProjectProcGetResponse>(request);
        }


        /// <summary>
        /// 查询项目详情
        /// </summary>
        /// <returns></returns>
        public ProjectGetResponse ProjectDetail(ProjectGetRequest request)
        {
            return ApiRequestHelp.Post<ProjectGetRequest, ProjectGetResponse>(request);
        }


        /// <summary>
        /// 项目阶段详情
        /// </summary>
        /// <param name="ProjectStageId"></param>
        /// <returns></returns>
        public StageGetResponse StageDetail(StageGetRequest request)
        {
            return ApiRequestHelp.Post<StageGetRequest, StageGetResponse>(request);
        }

        /// <summary>
        /// 新增阶段
        /// </summary>
        /// <returns></returns>
        public StageAddResponse AddStage(StageAddRequest request)
        {
            return ApiRequestHelp.Post<StageAddRequest, StageAddResponse>(request);
        }

        /// <summary>
        /// 逻辑删除修改阶段
        /// </summary>
        public StageStausUpdateResponse DeleteStage(StageStausUpdaterequest request)
        {
            return ApiRequestHelp.Post<StageStausUpdaterequest, StageStausUpdateResponse>(request);
        }

        /// <summary>
        /// 修改阶段
        /// </summary>
        /// <returns></returns>
        public StageUpdateResponse UpdateStage(StageUpdaterequest request)
        {
            return ApiRequestHelp.Post<StageUpdaterequest, StageUpdateResponse>(request);
        }

        /// <summary>
        /// 阶段反填
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        //public StageBackFillGetResponse StageBackFill(StageBackFillGetRequest request)
        //{
        //    return ApiRequestHelp.Post<StageBackFillGetRequest, StageBackFillGetResponse>(request);
        //}

        /// <summary>
        /// 修改项目状态
        /// </summary>
        /// <returns></returns>
        public ProjectStausUpdateReponse UpdateProjectStaus(ProjectStausUpdateRequest request)
        {
            return ApiRequestHelp.Post<ProjectStausUpdateRequest, ProjectStausUpdateReponse>(request);
        }

        /// <summary>
        /// 绑定项目状态
        /// </summary>
        /// <returns></returns>
        public ProjectBandGetResponse BandProjectStaus(ProjectBandGetRequest request)
        {
            return ApiRequestHelp.Post<ProjectBandGetRequest, ProjectBandGetResponse>(request);
        }
        /// <summary>
        /// 逻辑删除项目
        /// </summary>
        /// <returns></returns>
        public ProjectStausDeleteResponse UpdateStausProject(ProjectStausDeleteRequest request)
        {
            return ApiRequestHelp.Post<ProjectStausDeleteRequest, ProjectStausDeleteResponse>(request);
        }
    }
}
