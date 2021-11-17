using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Universe
{
    public class QuickSlotUI : MonoBehaviour
    {
        public Image WeaponIcon;
        public Image ItemIcon;
        
        public void UpdateWeaponQuickSlotsUI(bool isWeapon, WeaponItem weapon)
        {
            if(isWeapon == false)
            {
                if(weapon.itemIcon != null)
                {
                    ItemIcon.sprite = weapon.itemIcon;
                    ItemIcon.enabled = true;
                }
                else
                {
                    ItemIcon.sprite = null;
                    ItemIcon.enabled = false;
                }
            }
            else
            {
                if(weapon.itemIcon != null)
                {
                    WeaponIcon.sprite = weapon.itemIcon;
                    WeaponIcon.enabled = true;
                }
                else
                {
                    WeaponIcon.sprite = null;
                    WeaponIcon.enabled = false;
                }
            }
        }
    }
}
