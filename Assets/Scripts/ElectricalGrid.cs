using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricalGrid : MonoBehaviour
{
    private List<Tuple<float, float>> allPoles;

    void Awake()
    {
        this.allPoles = new List<Tuple<float, float>>();
    }

    public void AddPole(float voltage, float amperage)
    {
        this.allPoles.Add(new Tuple<float, float>(voltage, amperage));
    }
}

