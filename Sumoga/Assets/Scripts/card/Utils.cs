using System.Collections.Generic;
using System.Linq;
using serialization;
using UnityEditor;
using UnityEngine;

namespace card
{
    public static class Utils
    {
        /// <summary>
        /// This method tries to imitate drawing a card from a stack.
        /// </summary>
        /// <returns>A random card</returns>
        public static Card GenerateRandomCard()
        {
            var card = LoadCards()[0];
            return card;
        }

        public static List<Card> LoadCards()
        {
            var json = AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/Json/cards.json");
            return JsonHelper.FromJson<Card>(json.text).ToList();
        }
    }
}