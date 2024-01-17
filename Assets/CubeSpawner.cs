using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefabVar;
    
    // Use this for initialization
    void Start()
    {
        Instantiate( cubePrefabVar );
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate( cubePrefabVar );
        GameObject CubeGO = Instantiate<GameObject>(cubePrefabVar);
        Material mat = CubeGO.GetComponent<Renderer>().material;
        mat.color = Random.ColorHSV(0, 1, 0.5f, 1, .75f, 1);
    }
}
