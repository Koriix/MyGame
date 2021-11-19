using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Universe
{
    public class EnemyStats : CharacterStats
    {
        Animator animator;

        private void Awake()
        {
            animator = GetComponentInChildren<Animator>();
        }

        void Start()
        {
            maxHealth = SetMaxHealthFromHealthLevel();
            currentHealth = maxHealth;
        }

        private int SetMaxHealthFromHealthLevel()
        {
            maxHealth = healthLevel * 10;
            return maxHealth;
        }

        public void TakeDamage(int damage)
        {
            currentHealth = currentHealth - damage;
            animator.Play("Damage_1");

            if(currentHealth <= 0)
            {
                currentHealth = 0;
                animator.Play("Death_1");
            }
        }
    }
}