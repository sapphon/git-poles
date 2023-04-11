using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pole : MonoBehaviour
{
    public GameObject bottomPrefab;
    public GameObject middlePrefab;
    public GameObject transformerPrefab;
    public GameObject wiresPrefab;

    private float voltage = 120;
    private float amperage = 200;
    
    void Start()
    {
        this.BuildPole();
        this.ConnectToGrid();
    }

    void BuildPole()
    {
        GameObject poleBase = GameObject.FindGameObjectWithTag("Pole Base");
        Instantiate(bottomPrefab, poleBase.transform);
        Instantiate(middlePrefab, poleBase.transform);
        Instantiate(transformerPrefab, poleBase.transform);
        Instantiate(wiresPrefab, poleBase.transform);
    }
    
    void ConnectToGrid()
    {
        FindObjectOfType<ElectricalGrid>().AddPole(voltage, amperage);
    }
}
