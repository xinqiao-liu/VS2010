using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KM.KYData.Model
{
    public sealed class KYZ_User
    {
        public String UID { get; set; }                 //VARCHAR(20)   NotNULL 用户编号
        public String Username { get; set; }            //VARCHAR(20)   NotNULL 用户名称
        public String Fullname { get; set; }            //VARCHAR(40)   NotNULL 用户全名
        public String Password { get; set; }            //VARCHAR(80)   NotNULL 用户密码
        public String OfficeTelephone { get; set; }     //VARCHAR(14)           办公电话
        public String Mobile { get; set; }              //VARCHAR(11)           移动电话
        public String Email { get; set; }               //VARCHAR(40)           电子邮箱
        public DateTime LoginDate { get; set; }         //DateTime              最后登陆时间
        public DateTime ResetPasswordDate { get; set; } //DateTime      NotNULL 最后修密时间
        public DateTime ErrLoginDate { get; set; }      //DateTime              最后错登时间
        public Int32 ErrLoginCount { get; set; }        //INT           NotNULL 最后错登计数
        public String Symbol { get; set; }              //CHAR(4)               站内或站外

        public String CID { get; set; }                 //VARCHAR(18)           ID卡号

        public override String ToString()
        {
            return String.Format("{0}-{1}", this.UID, this.Username);
        }
    }
}
