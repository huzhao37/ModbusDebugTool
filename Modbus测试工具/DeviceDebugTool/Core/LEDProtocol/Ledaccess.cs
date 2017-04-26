using System;
using System.Runtime.InteropServices;
using System.Text;
//using RzFrame.pub;
using System.Data;
using System.IO;

namespace DeviceDebugTool.Core.LEDProtocol
{
    /// <summary>
    /// Ledaccess ��ժҪ˵����
    /// </summary>
    public class TDLedAccess
    {
        public TDLedAccess()
        {

        }
        // TFileParam
        [StructLayout(LayoutKind.Sequential)]
        private struct TFileParam
        {
            public byte Effect;	//���ŷ�ʽ 0~16������ע1��
            public byte Level;	//�ٶȼ��� 0~7 ��0����/7��죩
            public byte Speed;	//�����ٶ� 0~31��0���/31������
            public byte Delay;	//ͣ��ʱ�� 0~99
            //���²��������ı��ļ���Ч��ͼ���ļ���Ϊ����ֵ
            public byte Font;		//�����С 16��24
            public byte ShowTitle;	//�Ƿ���ʾ���� 0����/1��ʾ
            public byte TitleColor;	//������ɫ 0��/1��/2��
            public byte WordColor;	//������ɫ 0��/1��/2��
        }

        private static int intAddr;
        private static int intCom;
        private static int intBaud;
        private static int intDelay;
        //private static DataTable dtLedBase;
        private static TFileParam stuPara;




        private static string[] strArray = { "��������", "����ָ��Ϊ��", "�豸δ��", "�������ݲ���ȷ", "�ش����ճ�ʱ", "�ļ�������", "������ֹ", "������ֹ", "���г���", "���ɲ������ݳ���", "���ݱ��޼�¼", "���ձ�־����", "�������ݴ���", "�ļ��Ѵ���", "��������", "���Ͳ�ƥ��", "�쳣����", "��ֵ����ʾ", "δ֪�쳣" };


        public static void Init(int addr, int com, int baud, int delay)
        {

            intAddr = addr;
            intCom = com;
            intBaud = baud;
            intDelay = delay;
        }

        [DllImport("pArmSendQt.dll")]
        public static extern int SS_Open_Tcp(string sIP, int port, int delay);

        //�򿪴���
        [DllImport("pArmSendQt.dll")]
        private static extern int SS_Open_Com(int addr, int com, int baud, int delay);

        public static string OpenCom()
        {
            int intOk = SS_Open_Com(intAddr, intCom, intBaud, intDelay);
            return strArray[intOk];
        }

        //�رմ���
        [DllImport("pArmSendQt.dll")]
        public static extern int SS_Close();

        public static string CloseCom()
        {
            int intOk = SS_Close();
            if (intOk > 17)
            {
                intOk = 18;
            }
            return strArray[intOk];
        }

        //У����ʾ����ʱ�ӣ�ʹ֮���������ͬ����
        [DllImport("pArmSendQt.dll")]
        private static extern int SS_Send_Time();

        public static string SendTime()
        {
            int intOk = SS_Send_Time();
            return strArray[intOk];
        }

        //��ʾ����λ����ͬ��ʾ���ϵ縴λ��
        [DllImport("pArmSendQt.dll")]
        private static extern int SS_Send_Reset();

        public static string SendReset()
        {
            int intOk = SS_Send_Reset();
            return strArray[intOk];
        }

        //��ʾ�����Ÿ�λ��ʹ֮�ӹ��̵�һҳ��ʼ���š�
        [DllImport("pArmSendQt.dll")]
        private static extern int SS_Send_Replay();

        public static string SendReplay()
        {
            int intOk = SS_Send_Replay();
            return strArray[intOk];
        }

        //��ȡ��ʾ����ʵʱͨ�������б�
        [DllImport("pArmSendQt.dll")]
        private static extern String SS_Get_Window_List();

        public static string GetWindowList()
        {
            string strList = SS_Get_Window_List();
            return strList;
        }

        //����ʵʱ����
        [DllImport("pArmSendQt.dll")]
        private static extern int SS_Send_File(int W_index, ref TFileParam param, string ListFile, bool IsSave);

        public static string SendInfo(string strListFile, string strType)
        {
            int intWindex;

            if (strType == "week")
            {
                intWindex = 0;
                stuPara.Effect = 16;
                stuPara.Level = 7;
                stuPara.Speed = 0;
                stuPara.Delay = 10;
            }
            else
            {
                intWindex = 1;
                stuPara.Effect = 8;
                stuPara.Level = 1;
                stuPara.Speed = 7;
                stuPara.Delay = 2;
            }

            int intOk = SS_Send_File(intWindex, ref stuPara, strListFile, true);
            return strArray[intOk];
        }

        //����ʵʱ����
        //		[DllImport("pArmSendQt.dll")]
        //		private static extern int SS_Send_Buffer(int W_index,ref TFileParam param,string Buffer,bool IsSave);
        //		public static string CloseCom()
        //		{
        //			return Infotransfer(SS_Close());
        //		}
        //����ʵʱ����
        [DllImport("pArmSendQt.dll")]
        public static extern int SS_Send_Buffer_Ex(int W_index, int Effect, int Speed, int Delay, int FontSize, int Color, string Buffer, bool IsSave);


        //ɾ�����ش洢���б����ʵʱ�����ļ�
        [DllImport("pArmSendQt.dll")]
        private static extern int SS_Delete_File(int W_index);
        public static string DeleteWeekInfo()//ͨ��������
        {
            int intOk = SS_Delete_File(0);
            return strArray[intOk];
        }

        public static string DeleteDayInfo()//ͨ��������
        {
            int intOk = SS_Delete_File(1);
            return strArray[intOk];
        }
    }
}
