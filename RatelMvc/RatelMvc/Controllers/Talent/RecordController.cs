
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Talent;
using Newtonsoft.Json;

namespace RatelMvc.Controllers.Talent
{
    public class RecordController : Controller
    {
        HttpClientHelper helper = new HttpClientHelper("http://localhost:8066/");
        // GET: Record
        public ActionResult AddRecoed()
        {
            return View();
        }
        [HttpPost]
        public void AddRecoed(RecordModel model)
        {
            string str = helper.Post("/api/Record/AddRecoed", JsonConvert.SerializeObject(model));
            int i = int.Parse(str);
            if (i > 0)
            {
                Response.Write("<script>alert('添加成功');location.href='/Record/Index/'</script>");
            }
            else
            {
                Response.Write("<script>alert('添加成功')</script>");
            }
        }
        [HttpGet]
        public ActionResult Index()
        {
            string json = helper.Get("api/Record/ShowRecoed");
            List<RecordModel> list = JsonConvert.DeserializeObject<List<RecordModel>>(json);
            return View(list);
        }
        public void DeleteRecoed(int Id)
        {
            string str = helper.Delete("api/Record/DeleteRecoed/?Id=" + Id);

            int i = int.Parse(str);

            if (i > 0)
            {
                Response.Write("<script>alert('删除成功');location.href='/Record/Index/';</script>");
            }
            else
            {
                Response.Write("<script>alert('删除失败');location.href='/Record/Index/';</script>");
            }
        }

    }
}