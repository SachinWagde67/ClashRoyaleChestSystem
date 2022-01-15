using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace Chests
{ 
    public class ChestView : MonoBehaviour
    {
        public ChestController chestController;
        public Sprite lockedChestSprite;
        public Sprite unlockedChestSprite;
        public bool isChestSprite = false;

        [SerializeField] private TextMeshProUGUI chestTimerTxt;
        [SerializeField] private TextMeshProUGUI unlockGemsTxt;
        [SerializeField] private TextMeshProUGUI chestStatusTxt;
        [SerializeField] private Image chestSlotSprite;
        [SerializeField] private TextMeshProUGUI chestTypeTxt;
        [SerializeField] private TextMeshProUGUI coinsTxt;
        [SerializeField] private TextMeshProUGUI gemsTxt;

        private void Start()
        {
            makeParent();
            chestController.instantiateEmptyChest();
        }

        private void Update()
        {
            
            if (chestController.isStartTime)
            {
                chestController.startUnlocking();
            }
        }

        private void makeParent()
        {
            this.transform.SetParent(ChestService.Instance.chestSlotGroup.transform);
            this.transform.localScale = ChestService.Instance.chestSlotGroup.transform.localScale;
        }

        public void setChestController(ChestController controller)
        {
            chestController = controller;
        }

        public void showChestData()
        {
            coinsTxt.text = chestController.coins.ToString();
            gemsTxt.text = chestController.gems.ToString();
            if(chestController.unlockTime <= 0)
            {
                chestController.unlockTime = 0;
            }
            chestTimerTxt.text = "Unlock Time: " + chestController.unlockTime.ToString();
            unlockGemsTxt.text = "Unlock Gems: " + chestController.unlockWithGems.ToString();
            chestStatusTxt.text = chestController.chestStatus;
            chestTypeTxt.text = chestController.chestType.ToString();
            if (chestController.isLocked || chestController.isEmpty)
            {
                chestSlotSprite.sprite = lockedChestSprite;
            }
            else
            {
                isChestSprite = true;
                chestSlotSprite.sprite = unlockedChestSprite;
            }
        }

        public void onChestBtnClicked()
        {
            chestController.chestBtnClicked();
        }

        public void showUnlockTime(int time)
        {
            chestTimerTxt.text = "Unlock Time: " + time.ToString();
        }

        public void showUnlockGems(int gems)
        {
            unlockGemsTxt.text = "Unlock Gems:" + gems.ToString();
        }
    }
}
