﻿using UnityEngine;
using System;

public class Player
{
    public int CurrentHealth { get; private set; }
    public int MaximumtHealth { get; private set; }

    public Player(int currentHealth, int maximumHealth = 12)
    {
        if (currentHealth < 0)
            throw new ArgumentOutOfRangeException(nameof(currentHealth));

        if (currentHealth > maximumHealth)
            throw new ArgumentOutOfRangeException(nameof(currentHealth));

        CurrentHealth = currentHealth;
        MaximumtHealth = maximumHealth;
    }

    public void Heal(int amount)
    {
        var newHealth = Mathf.Min(CurrentHealth + amount, MaximumtHealth);

        CurrentHealth = newHealth;
    }

    public void TakeDamage(int amount)
    {
        var newHealth = Mathf.Max(CurrentHealth - amount, 0);

        CurrentHealth = newHealth;
    }
}