using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _32ServoManager
{
    public class MyConvert
    {
        //byte[]转16进制格式string：new byte[]{ 0x30, 0x31}转成"3031":
        public static string ToHexString(byte[] bytes) // 0xae00cf => "AE00CF "
        {
            string hexString = string.Empty;
            if (bytes != null)
            {
                StringBuilder strB = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    strB.Append(bytes[i].ToString("X2"));
                }
                hexString = strB.ToString();
            }
            return hexString;
        }


        //16进制格式string 转byte[]：
        //public static byte[] GetBytes(string hexString, out int discarded)
        //{
            //discarded = 0;
            //string newString = "";
            //char c;// remove all none A-F, 0-9, charactersfor (int i=0; i<hexString.Length; i++)
            //{              
            //  c = hexString[i];if (IsHexDigit(c))                    
            //newString += c;
            //else                    
            //discarded++;            
            //}// if odd number of characters, discard last characterif (newString.Length % 2 != 0){                discarded++;                
            //newString = newString.Substring(0, newString.Length-1);            
            //int byteLength = newString.Length / 2;byte[] bytes = newbyte[byteLength];string hex;int j = 0;for (int i=0; i<bytes.Length; i++){               
            // hex = new String(new Char[] {newString[j], newString[j+1]});              
            // bytes[i] = HexToByte(hex);                j = j+2;           
            // }
            //return bytes;       
        //}
    }
}
