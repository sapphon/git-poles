using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pole : MonoBehaviour
{
    public GameObject bottomPrefab;
    public GameObject middlePrefab;
    public GameObject topPrefab;

    void Start()
    {
        this.BuildPole();
    }

    void BuildPole()
    {
        GameObject poleBase = GameObject.FindGameObjectWithTag("Pole Base");
        Instantiate(bottomPrefab, poleBase.transform);
        Instantiate(middlePrefab, poleBase.transform);
        Instantiate(topPrefab, poleBase.transform);
    }
}
