using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ReimbursementInfo
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string ApplyName { get; set; }
        /// <summary>
        /// 报销类型
        /// </summary>
        public int CostId { get; set; }
        /// <summary>
        /// 报销日期
        /// </summary>
        public DateTime ApplyTime { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public decimal Money { get; set; }
        /// <summary>
        /// 同行人员
        /// </summary>
        public string Field { get; set; }
        /// <summary>
        /// 下班时间
        /// </summary>
        public DateTime ClosingTime { get; set; }
        /// <summary>
        /// 上车时间
        /// </summary>
        public DateTime PickUpTime { get; set; }
        /// <summary>
        /// 下车时间
        /// </summary>
        public DateTime GetOffTime { get; set; }
        /// <summary>
        /// 报销说明
        /// </summary>
        public string ApplyExplain { get; set; }
        /// <summary>
        /// 状态 
        /// </summary>
        public int ApplyState { get; set; }
    }
}
