using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour
{
    //creamos un objeto de tipo GameObject
    public GameObject prefabEsfera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        //se le asigna el color al objeto
        prefabEsfera.GetComponent<MeshRenderer>().material.color = c;
    }
    
}
