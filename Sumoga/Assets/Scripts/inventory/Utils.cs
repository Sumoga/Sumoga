using System.Collections.Generic;
using System.Linq;
using player;
using serialization;
using UnityEditor;
using UnityEngine;

namespace inventory
{
    public static class Utils
    {
        public static Inventory CreateStartingInventory()
        {
            var inventory = new Inventory();
            

            return inventory;
        }

        public static List<Item> LoadItems()
        {
            var json = AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/Json/items.json");
            return JsonHelper.FromJson<Item>(json.text).ToList();
        }
    }
}