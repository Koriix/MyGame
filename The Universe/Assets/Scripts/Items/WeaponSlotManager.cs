using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Universe 
{
    public class WeaponSlotManager : MonoBehaviour
    {
        WeaponHolderSlot HandSlot;

        DamageCollider HandDamageCollider;

        Animator animator;

        QuickSlotUI quickSlotUI;

        private void Awake()
        {
            animator = GetComponent<Animator>();
            quickSlotUI = FindObjectOfType<QuickSlotUI>();
            WeaponHolderSlot[] weaponHolderSlots = GetComponentsInChildren<WeaponHolderSlot>();
            foreach(WeaponHolderSlot weaponSlot in weaponHolderSlots)
            {
                if(weaponSlot.isHandSlot)
                {
                    HandSlot = weaponSlot;
                }
            }
        }
        public void LoadWeaponOnSlot(WeaponItem weaponItem, bool inHand)
        {
            if(inHand)
            {
                HandSlot.LoadWeaponModel(weaponItem);
                LoadWeaponDamageCollider();
                quickSlotUI.UpdateWeaponQuickSlotsUI(true, weaponItem);

                #region Handle Right Weapon Idle Animations
                if(weaponItem != null)
                {
                    animator.CrossFade(weaponItem.Axe_Idle, 0.2f);
                }
                else
                {
                    animator.CrossFade("Right Arm Empty", 0.2f);
                }

                #endregion
            }
        }

        #region Handle Weapon's Damage Collider

        private void LoadWeaponDamageCollider()
        {
            HandDamageCollider = HandSlot.currentWeaponModel.GetComponentInChildren<DamageCollider>();
        }

        public void OpenDamageCollider()
        {
            HandDamageCollider.EnableDamageCollider();
        }

        public void CloseDamageCollider()
        {
            HandDamageCollider.DisableDamageCollider();
        }

        #endregion
    }
}