using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WLDataLogicLayer
{
    public static class Message
    {
        //基础错误信息定义
        public static readonly string E1010 = "未选择列表项！";

        //运单错误信息定义
        public static readonly string E2000 = "指定运单绑定数据无效！";
        public static readonly string E2010 = "指定运单数据已经变化！";

        //中心错误信息定义
        public static readonly string E3050 = "无法读取指定中心运单！";
    }
}
