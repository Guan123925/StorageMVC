using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using SDKClient;

namespace RatelMvc.Controllers
{
    public class ProjectController : Controller
    {
        ProjectBll bll = new ProjectBll();
        // GET: Project
        public ActionResult InfoMation()
        {
            return View();
        }
        public ActionResult Detail()
        {
            return View();
        }

        public ActionResult AddProjectAndStage()
        {
            return View();
        }

        public ActionResult StageUpdate()
        {
            return View();
        }

        [HttpPost]
        /// <summary>
        /// 阶段反填
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public JsonResult StageBackFill(StageBackFillGetRequest request)
        {
            return Json(bll.StageBackFill(request));
        }
        [HttpPost]
        /// <summary>
        /// 项目参与人员绑定
        /// 根据所在职位部门
        /// </summary>
        public JsonResult BandProjectbinding(UserGetProjectRequest request)
        {
            return Json(bll.BandProjectbinding(request));
        }

        /// <summary>
        /// 新增项目
        /// </summary>
        public JsonResult AddProject(ProjectAddRequest request)
        {
            return Json(bll.AddProject(request));
        }

        [HttpPost]
        /// <summary>
        /// 修改项目
        /// </summary>
        /// <returns></returns>
        public JsonResult UpdateProject(ProjectUpdateRequest request)
        {
            return Json(bll.UpdateProject(request));
        }

        [HttpPost]
        /// <summary>
        /// 分页显示所有项目
        /// </summary>
        /// <returns></returns>
        public JsonResult ProjectShow(ProjectProcGetRequest request)
        {
            return Json(bll.ProjectShow(request));
        }

        [HttpPost]
        /// <summary>
        /// 查询项目详情
        /// </summary>
        /// <returns></returns>
        public JsonResult ProjectDetail(ProjectGetRequest request)
        {
            return Json(bll.ProjectDetail(request));
        }

        [HttpPost]
        /// <summary>
        /// 项目阶段详情
        /// </summary>
        /// <param name="ProjectStageId"></param>
        /// <returns></returns>
        public JsonResult StageDetail(StageGetRequest request)
        {
            return Json(bll.StageDetail(request));
        }

        [HttpPost]
        /// <summary>
        /// 新增阶段
        /// </summary>
        /// <returns></returns>
        public JsonResult AddStage(StageAddRequest request)
        {
            return Json(bll.AddStage(request));
        }

        [HttpPost]
        /// <summary>
        /// 逻辑删除修改阶段
        /// </summary>
        public JsonResult DeleteStage(StageStausUpdaterequest request)
        {
                return Json(bll.DeleteStage(request));
        }

        [HttpPost]
        /// <summary>
        /// 修改阶段
        /// </summary>
        /// <returns></returns>
        public JsonResult UpdateStage(StageUpdaterequest request)
        {
                return Json(bll.UpdateStage(request));
            }

        [HttpPost]
        /// <summary>
        /// 修改项目状态
        /// </summary>
        /// <returns></returns>
        public JsonResult UpdateProjectStaus(ProjectStausUpdateRequest request)
        {
                return Json(bll.UpdateProjectStaus(request));
            }

        [HttpPost]
        /// <summary>
        /// 绑定项目状态
        /// </summary>
        /// <returns></returns>
        public JsonResult BandProjectStaus(ProjectBandGetRequest request)
        {
                return Json(bll.BandProjectStaus(request));
            }

        [HttpPost]
        /// <summary>
        /// 逻辑删除项目
        /// </summary>
        /// <returns></returns>
        public JsonResult UpdateStausProject(ProjectStausDeleteRequest request)
        {
                return Json(bll.UpdateStausProject(request));
            }
    }
}