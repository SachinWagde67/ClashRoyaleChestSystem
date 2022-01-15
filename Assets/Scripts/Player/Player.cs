using UnityEngine;
using TMPro;

namespace PlayerData
{
    public class Player : SingletonGeneric<Player>
    {
        private bool isEnoughGems;

        [SerializeField] private int coins;
        [SerializeField] private int gems;
        [SerializeField] private TextMeshProUGUI coinTxt;
        [SerializeField] private TextMeshProUGUI gemsTxt;

        private void Start()
        {
            showPlayerData();
        }

        private void showPlayerData()
        {
            coinTxt.text = "Coins: " + coins.ToString();
            gemsTxt.text = "Gems: " + gems.ToString();
        }

        public void addCoinsAndGems(int _coins, int _gems)
        {
            coins += _coins;
            gems += _gems;
            showPlayerData();
        }

        public bool removeGems(int _gems)
        {
            if(_gems <= gems)
            {
                gems -= _gems;
                isEnoughGems = true;
            }
            else
            {
                isEnoughGems = false;
            }
            showPlayerData();
            return isEnoughGems;
        }
    }
}
