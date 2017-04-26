//****************************************************************************
//
//  File:      SubMain.cs
//
//  Copyright (c) HU ZHAO
//
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
//****************************************************************************
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModbusDebugTool
{

    class SkinClass
    {
        public static Sunisoft.IrisSkin.SkinEngine se = null;
        /// <summary> 
        /// 增加换肤菜单 
        /// </summary> 
        /// <param name="toolMenu"></param> 
        public static void AddSkinMenu(ToolStripMenuItem toolMenu)
        {
            DataSet skin = new DataSet();
            try
            {

                skin.ReadXml("skin.xml", XmlReadMode.Auto);
            }
            catch
            {

            }
            if (skin == null || skin.Tables.Count < 1)
            {
                skin = new DataSet();
                skin.Tables.Add("skin");
                skin.Tables["skin"].Columns.Add("style");
                System.Data.DataRow dr = skin.Tables["skin"].NewRow();
                dr[0] = "系统默认";
                skin.Tables[0].Rows.Add(dr);
                skin.WriteXml("skin.xml", XmlWriteMode.IgnoreSchema);
            }
            foreach (SkinType st in (SkinType[])System.Enum.GetValues(typeof(SkinType)))
            {
                toolMenu.DropDownItems.Add(new ToolStripMenuItem(st.ToString()));

                toolMenu.DropDownItems[toolMenu.DropDownItems.Count - 1].Click += new EventHandler(frm_Main_Click);
                if (st.ToString() == skin.Tables[0].Rows[0][0].ToString())
                {
                    ((ToolStripMenuItem)toolMenu.DropDownItems[toolMenu.DropDownItems.Count - 1]).Checked = true;
                    frm_Main_Click(toolMenu.DropDownItems[toolMenu.DropDownItems.Count - 1], null);

                }

            }

            toolMenu.DropDownItems.Add(new ToolStripMenuItem("系统默认"));
            toolMenu.DropDownItems[toolMenu.DropDownItems.Count - 1].Click += new EventHandler(frm_Main_Click);
            if (skin.Tables[0].Rows[0][0].ToString() == "系统默认")
            {
                ((ToolStripMenuItem)toolMenu.DropDownItems[toolMenu.DropDownItems.Count - 1]).Checked = true;
            }
        }
        static void frm_Main_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < ((ToolStripMenuItem)((ToolStripMenuItem)sender).OwnerItem).DropDownItems.Count; i++)
            {
                if (((ToolStripMenuItem)sender).Text == ((ToolStripMenuItem)((ToolStripMenuItem)sender).OwnerItem).DropDownItems[i].Text)
                {
                    ((ToolStripMenuItem)sender).CheckState = CheckState.Checked;
                    DataSet skin = new DataSet();
                    skin.Tables.Add("skin");
                    skin.Tables["skin"].Columns.Add("style");
                    System.Data.DataRow dr = skin.Tables["skin"].NewRow();
                    dr[0] = ((ToolStripMenuItem)((ToolStripMenuItem)sender).OwnerItem).DropDownItems[i].Text;
                    skin.Tables[0].Rows.Add(dr);
                    skin.WriteXml("skin.xml", XmlWriteMode.IgnoreSchema);

                }
                else
                {
                    ((ToolStripMenuItem)((ToolStripMenuItem)((ToolStripMenuItem)sender).OwnerItem).DropDownItems[i]).CheckState = CheckState.Unchecked;
                }
            }
            if (((ToolStripMenuItem)sender).Text == "系统默认")
            {
                RemoveSkin();
                DataSet skin = new DataSet();
                skin.Tables.Add("skin");
                skin.Tables["skin"].Columns.Add("style");
                System.Data.DataRow dr = skin.Tables["skin"].NewRow();
                dr[0] = "系统默认";
                skin.Tables[0].Rows.Add(dr);
                skin.WriteXml("skin.xml", XmlWriteMode.IgnoreSchema);
                return;
            }
            foreach (SkinType st in (SkinType[])System.Enum.GetValues(typeof(SkinType)))
            {
                if (st.ToString() == ((ToolStripMenuItem)sender).Text)
                {
                    ChangeSkin(st);
                    return;
                }
            }
        }
        /// <summary> 
        /// 改变皮肤 
        /// </summary> 
        /// <param name="st"></param> 
        public static void ChangeSkin(SkinType st)
        {
            System.Reflection.Assembly thisDll = System.Reflection.Assembly.GetExecutingAssembly();
            if (se == null)
            {
                //ModbusDebugTool是指命名空间，这里你可以换成你自己的。 
                se = new Sunisoft.IrisSkin.SkinEngine(Application.OpenForms[0], thisDll.GetManifestResourceStream("ModbusDebugTool.skin." + st.ToString() + ".ssk"));
                se.Active = true;
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    se.AddForm(Application.OpenForms[i]);
                }

            }
            else
            {
                //ModbusDebugTool是指命名空间，这里你可以换成你自己的。 
                se.SkinStream = thisDll.GetManifestResourceStream("ModbusDebugTool.bin.Debug.skin." + st.ToString() + ".ssk");
                se.Active = true;
            }
        }
        /// <summary> 
        /// 移除皮肤 
        /// </summary> 
        public static void RemoveSkin()
        {
            if (se == null)
            {
                return;
            }
            else
            {
                se.Active = false;
            }
        }
    }
    /// <summary> 
    /// 换肤类型 
    /// </summary> 
    public enum SkinType
    {
        Calmness,
        DeepCyan,
        Eighteen,
        Emerald,
        GlassBrown,
        Longhorn,
        MacOS,
        Midsummer,
        MP10,
        MSN,
        OneBlue,
        Page,
        RealOne,
        Silver,
        SportsBlack,
        SteelBlack,
        vista1,
        Vista2,
        Warm,
        Wave,
        XPSilver
    }

}
