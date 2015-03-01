using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

using ESRI.ArcGIS.ADF;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.SystemUI;

using MyPluginEngine;

namespace dataPreMenuBar
{
    /// <summary>
    /// 添加数据
    /// </summary>
    public class cAddData : MyPluginEngine.ICommand
    {
        private MyPluginEngine.IApplication hk;
        private System.Drawing.Bitmap m_hBitmap;

        private ESRI.ArcGIS.SystemUI.ICommand cmd = null;
        private IMapControlDefault _MapControl;
        public cAddData()
        {
            string str = @"..\Data\Image\MainTools\adddata.png";
            if (System.IO.File.Exists(str))
                m_hBitmap = new Bitmap(str);
            else
                m_hBitmap = null;
        }

        #region ICommand 成员

        public System.Drawing.Bitmap Bitmap
        {
            get { return m_hBitmap; }
        }

        public string Caption
        {
            get { return "添加数据"; }
        }

        public string Category
        {
            get { return "处理1"; }
        }

        public bool Checked
        {
            get { return false; }
        }

        public bool Enabled
        {
            get { return true; }
        }

        public int HelpContextId
        {
            get { return 0; }
        }

        public string HelpFile
        {
            get { return ""; }
        }

        public string Message
        {
            get { return "添加数据"; }
        }

        public string Name
        {
            get { return "AddData"; }
        }

        public void OnClick()
        {
            cmd.OnClick();
        }

        public void OnCreate(MyPluginEngine.IApplication hook)
        {
            if (hook != null)
            {
                this.hk = hook;
                cmd = new ControlsAddDataCommandClass();
                cmd.OnCreate(this.hk.MapControl);
                //_MapControl = this.hk.MapControl;
            }
        }

        public string Tooltip
        {
            get { return "添加数据"; }
        }

        #endregion
    }
}
