using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Universe
{
    public class PlayerAttacker : MonoBehaviour
    {

        AnimatorHandler animatorHandler;

        public void Awake()
        {
            animatorHandler = GetComponentInChildren<AnimatorHandler>();
        }

        public void HandleLightAttack(WeaponItem weapon)
        {
            animatorHandler.PlayerTargetAnimation(weapon.Light_Attack, true);
        }   

        public void HandleHeavyAttack(WeaponItem weapon)
        {
            animatorHandler.PlayerTargetAnimation(weapon.Heavy_Attack, true);
        }
    }
}