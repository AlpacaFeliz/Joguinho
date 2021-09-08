using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats
{
    // Atributos Gerais

    public float health;
    public float maxHealth;

    public int level;
    public float attack;
    public float deffense;
    public float vontade;

    public Stats(int level, float maxhealth, float attack, float deffense, float vontade)
    {
        this.level = level;
        this.health = maxHealth;

        this.attack = attack;
        this.deffense = deffense;
        this.vontade = vontade;
    }

    public Stats Clone()
    {
        return new Stats(this.level, this.maxHealth, this.attack, this.deffense, this.vontade);
    }



   
}
