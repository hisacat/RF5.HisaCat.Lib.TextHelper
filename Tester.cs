using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RF5.HisaCat.Lib.TextHelper
{
    internal static class Tester
    {
        public static void DoTest()
        {
            BepInExLoader.log.LogMessage(TextHelper.Item.GetItemName(ItemID.Item_Rabunomidorinku));
            BepInExLoader.log.LogMessage(TextHelper.Item.GetItemDiscript(ItemID.Item_Rabunomidorinku));

            BepInExLoader.log.LogMessage(TextHelper.Monster.GetMonsterName(MonsterID.enm001_Ork_01));
            BepInExLoader.log.LogMessage(TextHelper.Monster.GetMonsterDetail(MonsterID.enm001_Ork_01));

            BepInExLoader.log.LogMessage(TextHelper.System.GetSystemText(UITextDic.DICID.ADV_BED_OK));
        }
    }
}
