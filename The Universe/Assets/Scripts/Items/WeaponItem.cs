using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Universe
{
    [CreateAssetMenu(menuName = "Items/Weapon Item")]
    public class WeaponItem : Item
    {
        public GameObject modelPrefab;
        public bool isUnarmed;

        [Header("Idle Animations")]
        public string Axe_Idle_R;
        public string Axe_Idle_L;

        [Header("Attack Animations")]
        public string OH_Light_Attack_1;
        public string OH_Heavy_Attack_1;
    }

}
