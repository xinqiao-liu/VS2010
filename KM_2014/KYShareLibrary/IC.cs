using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;  //调用动态库一定要加入这个引用

namespace KM.Common
{
    public class IC
    {
        #region 常量定义

        //调用控制
        public const byte CTRL_NULL = 0x00;         //空操作
        public const byte CTRL_BLOCK0_EN = 0x01;    //操作第0块
        public const byte CTRL_BLOCK1_EN = 0x02;    //操作第1块
        public const byte CTRL_BLOCK2_EN = 0x04;    //操作第2块
        public const byte CTRL_NEEDSERIAL = 0x08;   //仅对指定序列号的卡操作
        public const byte CTRL_EXTERNKEY = 0x10;    //调用函数时需要输入密码认证，不置位则使用芯片内部存储密码进行认证
        public const byte CTRL_NEEDHALT = 0x20;     //读卡或写卡后顺便休眠该卡，休眠后，卡必须拿离开感应区，再放回感应区，才能进行第二次操作。

        //验证模式
        public const byte MODE_A = 1;               //新卡验证模式
        public const byte MODE_B = 0;               //

        #endregion

        #region 返回值定义

        public const String RESULE01 = "卡号已读取，但[0-2]块读取失败，可能刷卡过快！";
        public const String RESULE02 = "卡号及[0]块已读取，但[1-2]块读取失败，可能刷卡过快！";
        public const String RESULE03 = "卡号及[0-1]块已读取，但[2]块读取失败，可能刷卡过快！";
        public const String RESULE04 = "RESULE04";
        public const String RESULE05 = "RESULE05";
        public const String RESULE06 = "RESULE06";
        public const String RESULE07 = "RESULE07";
        public const String RESULE08 = "寻卡失败，序列号无效！/r/n错误原因：感应区中无卡。";
        public const String RESULE09 = "寻卡冲突，序列号无效！/r/n错误原因：感应区存在多张卡。";
        public const String RESULE10 = "卡号已读取，但该卡可能已休眠，无法选中！";
        public const String RESULE11 = "密码装载失败！";
        public const String RESULE12 = "密码认证失败！";
        public const String RESULE13 = "读块失败！/r/n错误原因：刷卡过快或该块所对应区没通过密码认证。";
        public const String RESULE14 = "写块失败！/r/n错误原因：刷卡过快或该块所对应区没通过密码认证。";
        public const String RESULE15 = "重置密码失败！";
        public const String RESULE16 = "RESULE16";
        public const String RESULE17 = "RESULE17";
        public const String RESULE18 = "RESULE18";
        public const String RESULE19 = "RESULE19";
        public const String RESULE20 = "RESULE20";
        public const String RESULE21 = "引用动态库ICUSB.DLL不在当前目录下！";
        public const String RESULE22 = "动态库或驱动程序异常！/r/n解决方法：退出程序并拔出IC卡读写器，重新驱动并再次插上IC卡读写器重试，或重新拷贝OURMIFARE.DLL到正确位置。";
        public const String RESULE23 = "驱动程序错误或尚未安装！";
        public const String RESULE24 = "操作超时！/r/n错误原因：可能电脑病毒导致USB数据调度缓慢或IC卡读写器异常。/r/n解决方法：重启电脑或重新插拔IC卡读写器。";

        //以下错误基本不会出现
        public const String RESULE25 = "发送字数不够！";
        public const String RESULE26 = "发送CRC校验错误！";
        public const String RESULE27 = "接收字数不够！";
        public const String RESULE28 = "接收CRC校验错误！";

        #endregion

        #region 外部函数声明

        //读卡
        [DllImport("OUR_MIFARE.dll", EntryPoint = "piccreadex")]
        static extern byte piccreadex(byte ctrlword, byte[] serial, byte area, byte keyA1B0, byte[] picckey, byte[] piccdata0_2);

        //写卡
        [DllImport("OUR_MIFARE.dll", EntryPoint = "piccwriteex")]
        static extern byte piccwriteex(byte ctrlword, byte[] serial, byte area, byte keyA1B0, byte[] picckey, byte[] piccdata0_2);

        //蜂鸣
        [DllImport("OUR_MIFARE.dll", EntryPoint = "pcdbeep")]
        static extern byte pcdbeep(ulong xms);

        //读取设备编号，可做为软件加密狗用,也可以根据此编号在公司网站上查询保修期限
        [DllImport("OUR_MIFARE.dll", EntryPoint = "pcdgetdevicenumber")]
        static extern byte pcdgetdevicenumber(byte[] devicenumber);

        //寻任意卡并返回序列号
        [DllImport("OUR_MIFARE.dll", EntryPoint = "piccrequest")]
        static extern byte piccrequest(byte[] serial);

        //寻指定卡并返回序列号
        [DllImport("OUR_MIFARE.dll", EntryPoint = "piccrequestex")]
        static extern byte piccrequestex(byte[] serial);

        //休眠
        [DllImport("OUR_MIFARE.dll", EntryPoint = "picchalt")]
        static extern byte picchalt();

        //重置卡扇区密码
        [DllImport("OUR_MIFARE.dll", EntryPoint = "piccchangesinglekey")]
        static extern byte piccchangesinglekey(byte ctrlword, byte[] serial, byte area, byte keyA1B0, byte[] piccoldkey, byte[] piccnewkey);

        #endregion
        
        #region 函数声明

        //获取返回值定义
        public static String GetResultMsg(byte result)
        {
            switch (result)
            {
                case 1:
                    return RESULE01;
                case 2:
                    return RESULE02;
                case 3:
                    return RESULE03;
                case 4:
                    return RESULE04;
                case 5:
                    return RESULE05;
                case 6:
                    return RESULE06;
                case 7:
                    return RESULE07;
                case 8:
                    return RESULE08;
                case 9:
                    return RESULE09;
                case 10:
                    return RESULE10;
                case 11:
                    return RESULE11;
                case 12:
                    return RESULE12;
                case 13:
                    return RESULE13;
                case 14:
                    return RESULE14;
                case 15:
                    return RESULE15;
                case 16:
                    return RESULE16;
                case 17:
                    return RESULE17;
                case 18:
                    return RESULE18;
                case 19:
                    return RESULE19;
                case 20:
                    return RESULE20;
                case 21:
                    return RESULE21;
                case 22:
                    return RESULE22;
                case 23:
                    return RESULE23;
                case 24:
                    return RESULE24;
                case 25:
                    return RESULE25;
                case 26:
                    return RESULE26;
                case 27:
                    return RESULE27;
                case 28:
                    return RESULE28;
                default:
                    return "未知错误！";
            }
        }

        //ctrlWord - 控制 BLOCK0_EN + BLOCK1_EN + BLOCK2_EN
        //serial   - 序列号数组 byte[] serial = new byte[4];        
        //area     - 扇区号，范围[0-15]
        //keyMode  - 验证模式，0：B密码 非0：A密码，刚出厂用A密码验证
        //key      - 密码数组 byte[] key = new byte[6];
        /*初始化密码数组
        icKey[0] = 0xff;
        icKey[1] = 0xff;
        icKey[2] = 0xff;
        icKey[3] = 0xff;
        icKey[4] = 0xff;
        icKey[5] = 0xff;
        */
        //data     - 数据缓冲区 byte[] data = new byte[48];

        //读卡
        public static bool ReadEx(byte[] serial, byte area, byte[] data)
        {
            return ReadEx(CTRL_BLOCK0_EN + CTRL_BLOCK1_EN + CTRL_BLOCK2_EN + CTRL_EXTERNKEY + CTRL_NEEDHALT, serial, area, 
                MODE_A, new byte[6] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff }, data);
        }

        public static bool ReadEx(byte ctrlWord, byte[] serial, byte area, byte keyMode, byte[] key, byte[] data)
        {
            try
            {
                #region 检查参数
                checkSerial(serial, String.Empty);
                checkArea(area, String.Empty);
                checkKey(key, String.Empty);
                checkData(data, String.Empty);
                #endregion

                byte result = piccreadex(ctrlWord, serial, area, keyMode, key, data);
                switch (result)
                {
                    case 0: //操作成功
                        return true;
                    case 8: //寻卡失败
                        return false;
                    default:
                        throw new ApplicationException(GetResultMsg(result));
                }
            }            
            catch (Exception ex)
            {
                throw new ApplicationException("读卡：" + ex.Message);
            }
        }

        //写卡
        //ctrlWord - 控制 BLOCK0_EN + BLOCK1_EN + BLOCK2_EN + EXTERNKEY + NEEDHALT
        //serial   - 序列号数组 byte[] serial = new byte[4];
        //area     - 扇区号，范围[0-15]
        //keyMode  - 验证模式，0：B密码 非0：A密码，刚出厂用A密码验证
        //key      - 密码数组 byte[] key = new byte[6];
        //data     - 数据缓冲区 byte[] data = new byte[48];
        public static bool WriteEx(byte ctrlWord, byte[] serial, byte area, byte keyMode, byte[] key, byte[] data)
        {
            try
            {
                #region 检查参数
                checkSerial(serial, String.Empty);
                checkArea(area, String.Empty);
                checkKey(key, String.Empty);
                checkData(data, String.Empty);
                #endregion

                byte result = piccwriteex(ctrlWord, serial, area, keyMode, key, data);
                switch (result)
                {
                    case 0: //操作成功
                        return true;
                    case 8: //寻卡失败
                        return false;
                    default:
                        throw new ApplicationException(GetResultMsg(result));
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("写卡：" + ex.Message);
            }
        }

        //蜂鸣
        public static void Beep()
        {
            Beep(50);
        }

        //蜂鸣，可指定时间，单位：2微秒
        public static void Beep(ulong xms)
        {
            byte result = pcdbeep(xms);
            switch (result)
            {
                case 0: //操作成功
                    break;
                default:
                    throw new ApplicationException(GetResultMsg(result));
            }
        }

        //读取设备字符串
        public static String ReadDeviceStr()
        {
            byte[] devno = ReadDeviceNumber();

            return System.Convert.ToString(devno[0]) + "-" + System.Convert.ToString(devno[1]) + "-" + System.Convert.ToString(devno[2]) + "-" + System.Convert.ToString(devno[3]);
        }

        //读取设备编号，可做为软件加密狗用,也可以根据此编号在公司网站上查询保修期限
        public static byte[] ReadDeviceNumber()
        {
            byte[] devno = new byte[4];

            byte result = pcdgetdevicenumber(devno);
            switch (result)
            {
                case 0: //操作成功
                    return devno;
                default:
                    throw new ApplicationException(GetResultMsg(result));
            }
        }

        //休眠
        public static void Halt()
        {
            byte result = picchalt();
            switch (result)
            {
                case 0: //操作成功
                    break;
                default:
                    throw new ApplicationException(GetResultMsg(result));
            }
        }

        //修改单区密码(注意：指定新密码时一定要记住，否则有可能找不回密码，导致该卡报废。）
        public static bool ResetKey(byte area, byte[] newKey)
        {
            byte[] oldKey = new byte[6];
            oldKey[0] = 0xff;
            oldKey[1] = 0xff;
            oldKey[2] = 0xff;
            oldKey[3] = 0xff;
            oldKey[4] = 0xff;
            oldKey[5] = 0xff;
            return ResetKey(area, MODE_A, oldKey, newKey);
        }

        public static bool ResetKey(byte area, byte[] oldKey, byte[] newKey)
        {
            return ResetKey(area, MODE_A, oldKey, newKey);
        }

        public static bool ResetKey(byte area, byte keyMode, byte[] oldKey, byte[] newKey)
        {
            return ResetKey(CTRL_NULL, new Byte[4], area, keyMode, oldKey, newKey);
        }

        public static bool ResetKey(byte ctrlWord, byte[] serial, byte area, byte keyMode, byte[] oldKey, byte[] newKey)
        {
            try
            {                
                #region 检查参数
                checkSerial(serial, String.Empty);
                checkArea(area, String.Empty);
                checkKey(oldKey, "旧");
                checkKey(newKey, "新");
                #endregion

                byte result = piccchangesinglekey(ctrlWord, serial, area, keyMode, oldKey, newKey);
                switch (result)
                {
                    case 0: //操作成功
                        return true;
                    case 8: //寻卡失败
                        return false;
                    default:
                        throw new ApplicationException(GetResultMsg(result));
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("修改扇区密码：" + ex.Message);
            }
        }

        private static void checkSerial(byte[] serial, String prefix)
        {
            if (serial == null) new ApplicationException(prefix + "序列号数组未初始化！");
            if (serial.Length > 4) new ApplicationException(prefix + "序列号数组长度无效！");
        }

        private static void checkArea(byte area, String prefix)
        {
            if (area < 0 || area > 15) new ApplicationException(prefix + "扇区号无效，范围 0 - 15 之间！");
        }

        private static void checkKey(byte[] key, String prefix)
        {
            if (key == null) new ApplicationException(prefix + "密码数组未初始化！");
            if (key.Length > 6) new ApplicationException(prefix + "密码号数组长度无效！");
        }

        private static void checkData(byte[] data, String prefix)
        {
            if (data == null) new ApplicationException(prefix + "数据数组未初始化！");
            if (data.Length > 48) new ApplicationException(prefix + "数据数组长度无效！");
        }

        #endregion
    }
}
