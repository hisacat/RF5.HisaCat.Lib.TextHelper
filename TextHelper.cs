using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RF5.HisaCat.Lib.TextHelper
{
    public static class TextHelper
    {
        public static class Item
        {
            public static string GetItemName(ItemID itemId)
            {
                return GetItemName(ItemDataTable.GetDataTable(itemId));
            }
            public static string GetItemName(ItemDataTable itemDataTable)
            {
                //Ways 1
                return SV.UIRes.GetText(SysTextGroup.ItemUINameData, itemDataTable.ItemIndex);
                //Ways 2
                return itemDataTable.ScreenName;
            }
            public static string GetItemDiscript(ItemID itemId)
            {
                return GetItemName(ItemDataTable.GetDataTable(itemId));
            }
            public static string GetItemDiscript(ItemDataTable itemDataTable)
            {
                //Ways 1
                return SV.UIRes.GetText(SysTextGroup.ItemUIDiscriptData, itemDataTable.ItemIndex);
                //Ways 2
                return itemDataTable.Describe;
            }
        }
        public static class Monster
        {
            public static string GetMonsterName(MonsterID monsterId)
            {
                return SV.UIRes.MonsterName(monsterId);
            }
            public static string GetMonsterDetail(MonsterID monsterId)
            {
                return SV.UIRes.MonsterDetail(monsterId);
            }
        }
        public static class System
        {
            public static string GetSystemText(UITextDic.DICID dicId)
            {
                return SV.UIRes.GetSystemText(dicId);
            }
        }
    }
}
