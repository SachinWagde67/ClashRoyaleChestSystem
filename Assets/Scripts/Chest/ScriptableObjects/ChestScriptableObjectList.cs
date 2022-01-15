using UnityEngine;

namespace ChestSO
{
    [CreateAssetMenu(fileName = "ChestScriptableObjectList", menuName = "Chest/ChestScriptableObjects/Chest List")]
    public class ChestScriptableObjectList : ScriptableObject
    {
        public ChestScriptableObject[] chestSOL;
    }
}
