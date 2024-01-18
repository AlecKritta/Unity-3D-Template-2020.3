using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawner : MonoBehaviour
{
    public GameObject spherePrefabVar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(spherePrefabVar);
        GameObject sphereGO = Instantiate<GameObject>(spherePrefabVar);
        Material mat = sphereGO.GetComponent<Renderer>().material;
        mat.color = Random.ColorHSV(0, 1, .5f, 1, .75f, 1);
    }
    
    
}
