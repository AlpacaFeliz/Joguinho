using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    private Fighter[] fighters;
    private int fighterIndex;

    void Start()
    {
        LogPanel.Write("Começou a bagaceira. ");

        this.fighterIndex = 0;
    }
}
