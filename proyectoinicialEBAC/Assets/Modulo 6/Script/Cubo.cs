using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
         //creamos un color aleatorio
        Color c = new Color(Random.value,Random.value,Random.value);
        //se le asigna el color al objeto
        GetComponent<MeshRenderer>().material.color = c;

    }
}
