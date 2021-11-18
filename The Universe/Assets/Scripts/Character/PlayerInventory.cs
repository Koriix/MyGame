using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Universe
{
    public class PlayerInventory : MonoBehaviour
    {
        WeaponSlotManager weaponSlotManager;
        public WeaponItem Hweapon;

        public WeaponItem unarmedWeapon;

        public WeaponItem[] weaponsInHandSlots = new WeaponItem[1];

        public int currentWeaponIndex = 0;

        public List<WeaponItem> weaponsInventory;

        private void Awake()
        {
            weaponSlotManager = GetComponentInChildren<WeaponSlotManager>();
        }

        private void Start()
        {
            Hweapon = unarmedWeapon;
        }

        public void ChangeWeapon()
        {
            currentWeaponIndex = currentWeaponIndex + 1;

            if(currentWeaponIndex == 0 && weaponsInHandSlots[0] != null)
            {
                Hweapon = weaponsInHandSlots[currentWeaponIndex];
                weaponSlotManager.LoadWeaponOnSlot(weaponsInHandSlots[currentWeaponIndex], false);
            }
            else if(currentWeaponIndex == 0 && weaponsInHandSlots[0] == null)
            {
                currentWeaponIndex = currentWeaponIndex + 1;
            }

            if(currentWeaponIndex > weaponsInHandSlots.Length - 1)
            {
                currentWeaponIndex = -1;
                Hweapon = unarmedWeapon;
                weaponSlotManager.LoadWeaponOnSlot(unarmedWeapon, false);
            }
        }
    }
}