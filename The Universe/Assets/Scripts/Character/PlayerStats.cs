using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Universe
{
    public class PlayerStats : MonoBehaviour
    {
        public int healthlevel = 10;
        public int maxHealth;
        public int currentHealth;
        public HealthBar healthBar;

        AnimatorHandler animatorHandler;

        private void Awake()
        {
            animatorHandler = GetComponentInChildren<AnimatorHandler>();
        }

        void Start()
        {
            maxHealth = SetMaxHealthFromHealthLevel();
            currentHealth = maxHealth;
            healthBar.SetMaxHealth(maxHealth);
        }

        private int SetMaxHealthFromHealthLevel()
        {
            maxHealth = healthlevel * 10;
            return maxHealth;
        }

        public void TakeDamage(int damage)
        {
            currentHealth = currentHealth - damage;

            healthBar.SetCurrentHealth(currentHealth);

            //animatorHandler.PlayTargetAnimation("Damage_1", true);

            if(currentHealth <= 0)
            {
                currentHealth = 0;
                //animatorHandler.PlayTargetAnimation("Death_1", true);
            }
        }
    }
}