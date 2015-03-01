using System;
using System.Collections.Generic;
using System.Text;
using MyPluginEngine;

namespace MyMainTools
{
    public class MainMenuBar:MyPluginEngine.IMenuDef
    {
        #region IMenuDef 成员

        public string Caption
        {
            get { return "文件"; }
        }

        public void GetItemInfo(int pos, ItemDef itemDef)
        {
            switch (pos)
            {
                case 0:
                    itemDef.ID = "MyMainTools.cRefreshView";
                    itemDef.Group = false;
                    break;
                case 1:
                    itemDef.ID = "MyMainTools.cZoomIn";
                    itemDef.Group = true;
                    break;
                case 2:
                    itemDef.ID = "MyMainTools.cZoomOut";
                    itemDef.Group = false;
                    break;
                case 3:
                    itemDef.ID = "MyMainTools.cPan";
                    itemDef.Group = false;
                    break;
                case 4:
                    itemDef.ID = "MyMainTools.cIdentify";
                    itemDef.Group = false;
                    break;
                case 5:
                    itemDef.ID = "MyMainTools.cFullExtent";
                    itemDef.Group = true;
                    break;
                case 6:
                    itemDef.ID = "MyMainTools.cAddData";
                    itemDef.Group = false;
                    break;
                ////case 7:
                //    //itemDef.ID = "MyMainTools.cIdentify";
                //    //itemDef.Group = true;
                //    break;
                default:
                    break;

            }
        }

        public long ItemCount
        {
            get { return 7; }
        }

        public string Name
        {
            get { return "MainMenu"; }
        }

        #endregion
    }
}
