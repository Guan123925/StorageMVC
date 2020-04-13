using Models.Talent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace RatelMvc.Controllers.Talent
{
    public class TalentsController : Controller
    {

        HttpClientHelper helper = new HttpClientHelper("http://localhost:51845/");
        public ActionResult Index(string CName)
        {
            string json = helper.Get("api/Talents/Show?CName=" + CName);
            List<TalentsModel> list = JsonConvert.DeserializeObject<List<TalentsModel>>(json);
            return View(list);
        }
        // GET: Talents
        public ActionResult AddTalent()
        {
            return View();
        }
        [HttpPost]
        public void AddTalent(TalentsModel model)
        {
            string str = helper.Post("/api/Talents/AddTalent", JsonConvert.SerializeObject(model));
            int i = int.Parse(str);
            if (i > 0)
            {
                Response.Write("<script>alert('添加成功');location.href='/Talents/Index/'</script>");
            }
            else
            {
                Response.Write("<script>alert('添加成功')</script>");
            }
        }

        public ActionResult UpdateTalent(int Id)
        {
            string json = helper.Get("api/Talents/TalentId?Id=" + Id);
            List<TalentsModel> list = JsonConvert.DeserializeObject<List<TalentsModel>>(json);
            return View(list);
        }
        [HttpPost]
        public void UpdateTalent(TalentsModel model)
        {
            string str = helper.Post("api/Talents/UpdateTalent", JsonConvert.SerializeObject(model));

            int i = int.Parse(str);

            if (i > 0)
            {
                //Response.Write("<script>alert('修改成功');location.href='/Talents/Index/'<script>");
                Response.Write("<script>alert('修改成功');location.href='/Talents/Index'</script>");
            }
            else
            {
                Response.Write("<script>alert('修改失败')<script>");
            }
        }
        public void DeleteTalent(int Id)
        {
            string str = helper.Delete("api/Talents/DeleteTalent/?Id=" + Id);

            int i = int.Parse(str);

            if (i > 0)
            {
                Response.Write("<script>alert('删除成功');location.href='/Talents/Index/';</script>");
            }
            else
            {
                Response.Write("<script>alert('删除失败');location.href='/Talents/Index/';</script>");
            }
        }
        [HttpGet]
        public ActionResult Detail(int Id)
        {
            string json = helper.Get("api/Talents/TalentId?Id=" + Id);
            List<TalentsModel> list = JsonConvert.DeserializeObject<List<TalentsModel>>(json);
            return View(list);
        }
    }
}