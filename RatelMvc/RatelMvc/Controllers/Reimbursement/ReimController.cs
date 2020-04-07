using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Model;

namespace RatelMvc.Controllers.Reimbursement
{
    public class ReimController : Controller
    {
        HttpClientHelper helper = new HttpClientHelper("http://localhost:51845");
        // GET: Reim
        public ActionResult add()
        {
            return View();
        }
        [HttpPost]
        public void add(ReimbursementInfo model)
        {
            string str = helper.Post("api/Reim/AddReimburse", JsonConvert.SerializeObject(model));
            int i = int.Parse(str);
            if (i > 0)
            {
                Response.Write("<script>alert('添加成功');location.href=''</script>");
            }
            else
            {
                Response.Write("<script>alert('添加成功')</script>");
            }
        }
        public ActionResult show()
        {
            string json = helper.Get("/api/Reim/Reimbursements");
            List<ReimbursementInfo> list = JsonConvert.DeserializeObject<List<ReimbursementInfo>>(json);
            return View(list);
        }
        public ActionResult Detail()
        {
            string json = helper.Get("/api/Reim/Reimbursements");
            List<ReimbursementInfo> list = JsonConvert.DeserializeObject<List<ReimbursementInfo>>(json);
            return View(list);
        }
       
    }
}