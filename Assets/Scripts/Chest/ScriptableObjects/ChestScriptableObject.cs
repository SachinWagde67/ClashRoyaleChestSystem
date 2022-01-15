using UnityEngine;

namespace ChestSO
{
    [CreateAssetMenu(fileName = "ChestScriptableObject", menuName = "Chest/ChestScriptableObjects/New Chest")]
    public class ChestScriptableObject : ScriptableObject
    {
        public ChestType chestType;
        public int unlockTime;
        public int minCoins;
        public int maxCoins;
        public int minGems;
        public int maxGems;
    }

    public enum ChestType
    {
        None,
        Common,
        Rare,
        Epic,
        Legendary
    }

}
