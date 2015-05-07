using System;
using System.Collections.Generic;
using System.Text;

namespace KM.Common
{
    public class Speach
    {
        private static Speach m_Instance = null;
        private SpeechLib.SpVoiceClass m_Voice = null;

        /// <summary>
        /// 音量
        /// </summary>
        public int Volume
        {
            get { return m_Voice.Volume; }
            set { m_Voice.SetVolume((ushort)(value)); }
        }

        /// <summary>
        /// 速度
        /// </summary>
        public int Rate
        {
            get { return m_Voice.Rate; }
            set { m_Voice.SetRate(value); }
        }

        private void Speak(string strSpeack)
        {
            m_Voice.Speak(strSpeack, SpeechLib.SpeechVoiceSpeakFlags.SVSFlagsAsync);
        }

        private void SetChinaVoice()
        {
            m_Voice.Voice = m_Voice.GetVoices(string.Empty, string.Empty).Item(0);
        }

        private void SetEnglishVoice()
        {
            m_Voice.Voice = m_Voice.GetVoices(string.Empty, string.Empty).Item(1);
        }

        private void SpeakChina(string strSpeak)
        {
            SetChinaVoice();
            Speak(strSpeak);
        }

        private void SpeakEnglish(string strSpeak)
        {
            SetEnglishVoice();
            Speak(strSpeak);
        }

        private void BuildSpeach()
        {
            if (m_Voice == null)
            {
                m_Voice = new SpeechLib.SpVoiceClass();
            }
            Rate = Rate + 4;
        }

        private Speach()
        {
            BuildSpeach();
        }

        public static Speach Instance()
        {
            if (m_Instance == null)
                m_Instance = new Speach();
            return m_Instance;
        }

        public void AnalyseSpeak(string strSpeak)
        {
            int iCbeg = 0;
            int iEbeg = 0;
            bool IsChina = true;
            for (int i = 0; i < strSpeak.Length; i++)
            {
                char chr = strSpeak[i];
                if (IsChina)
                {
                    if (chr <= 122 && chr >= 65)
                    {
                        int iLen = i - iCbeg;
                        string strValue = strSpeak.Substring(iCbeg, iLen);
                        SpeakChina(strValue);
                        iEbeg = i;
                        IsChina = false;
                    }
                }
                else
                {
                    if (chr > 122 || chr < 65)
                    {
                        int iLen = i - iEbeg;
                        string strValue = strSpeak.Substring(iEbeg, iLen);
                        this.SpeakEnglish(strValue);
                        iCbeg = i;
                        IsChina = true;
                    }
                }
            }//end for
            if (IsChina)
            {
                int iLen = strSpeak.Length - iCbeg;
                string strValue = strSpeak.Substring(iCbeg, iLen);
                SpeakChina(strValue);
            }
            else
            {
                int iLen = strSpeak.Length - iEbeg;
                string strValue = strSpeak.Substring(iEbeg, iLen);
                SpeakEnglish(strValue);
            }
        }

        public void Stop()
        {
            m_Voice.Speak(string.Empty, SpeechLib.SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak);
        }

        public void Pause()
        {
            m_Voice.Pause();
        }

        public void Continue()
        {
            m_Voice.Resume();
        }

        public static void Play(string str)
        {
            if (m_Instance == null)
                m_Instance = new Speach();
            m_Instance.AnalyseSpeak(str);
        }
    }
}
