using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleRestFullService
{
    public class GuideDelayCancelInfo
    {
        /// <summary>
        /// 体检编号、条码号
        /// </summary>
        public string checkNo { get; set; }

        /// <summary>
        /// 项目编码
        /// </summary>
        public string checkItemCode { get; set; }

        /// <summary>
        /// 设置项目状态值（3延检;４弃检 ，5取消延检;6取消弃检）
        /// </summary>
        public string itemStatus { get; set; }

        /// <summary>
        /// 延检日期（延检时yyyy-mm-dd ,其它为空串）
        /// </summary>
        public string delayDate { get; set; }

        /// <summary>
        /// 签名图片 base64串（无时为空串）
        /// </summary>
        public string signImage { get; set; }
    }
}
