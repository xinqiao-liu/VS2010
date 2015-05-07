using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;

namespace KM.Common
{
    public static class OLD_IC
    {
        private static System.IO.Ports.SerialPort serialPort = null;

        //初始化
        public static void InitPort(String portName, int baudRate, SerialDataReceivedEventHandler eventHandle)
        {
            serialPort = new System.IO.Ports.SerialPort();
            serialPort.BaudRate = baudRate;     //19200
            serialPort.PortName = portName;     //"COM7"
            serialPort.DataReceived += eventHandle;
        }

        public static void ClosePort()
        {
            if (serialPort != null) serialPort.Close();
        }

        public static int ReadByte()
        {
            return serialPort.ReadByte();
        }

        //蜂鸣
        private static void Beep()
        {
            if (serialPort == null) throw new ApplicationException("串口未初始化！");

            serialPort.Open();
            serialPort.Write(new byte[5] { 0x03, 0x0f, 0xff, 0x00, 0xf0 }, 0, 5);
            serialPort.Close();
        }

        //读卡号
        private static void ReadSN()
        {
            if (serialPort == null) throw new ApplicationException("串口未初始化！");

            serialPort.Open();
            serialPort.Write(new byte[3] { 0x01, 0xf0, 0xf0 }, 0, 3);
        }

        //读块
        private static void ReadBlock()
        {
            if (serialPort == null) throw new ApplicationException("串口未初始化！");

            serialPort.Open();
            byte[] bytes = new byte[16] { 0x0e, 0x78, 0x17, 0x00, 0x00, 0x00, 0x00, 0x01, 0xaa, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x00 };
            bytes[15] = XorCheck(bytes);    //校检码位置
            serialPort.Write(bytes, 0, 16);
        }

        //写块
        private static void WriteBlock()
        {
            if (serialPort == null) throw new ApplicationException("串口未初始化！");

            serialPort.Open();
            byte[] bytes = new byte[64] {0x3e,0x69, 0x37, 0x00, 0x00, 0x00, 0x00, 0x01, 0xaa, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                                            0x10,0x11,0x01,0x22,0x05,0x55,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                                            0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                                            0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                                            0x00
                                            };
            bytes[63] = XorCheck(bytes);    //校检码位置
            serialPort.Write(bytes, 0, bytes.Length);
        }

        //计算校检位
        private static byte XorCheck(byte[] bytes)
        {
            byte xc = bytes[1];
            for (int i = 1; i < bytes.Length - 1; i++)
            {
                if (i + 1 < bytes.Length - 1)
                {
                    xc ^= bytes[i + 1];
                }
            }
            return xc;
        }
    }
}
