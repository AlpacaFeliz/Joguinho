using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Fighter : MonoBehaviour
{
    public string idName;
    public StatusPanel statusPanel;

    public CombatManager combatManager;
    public Stats stats;

    protected virtual void Start()
    {
        this.statusPanel.SetStats(this.idName, this.stats);
    }

    public void Modifyhealth (float amount) {
        stats.health = Mathf.Clamp(stats.health + amount, 0f, stats.maxHealth);
        this.statusPanel.SetHealth(stats.health, stats.maxHealth);
    }

    public abstract void InitTurn();
}
