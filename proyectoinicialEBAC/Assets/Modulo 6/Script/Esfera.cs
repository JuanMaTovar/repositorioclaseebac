using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour
{
    public bool valor2=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Color c = new Color(Random.value, Random.value, Random.value);
        ////se le asigna el color al objeto
        //GetComponent<MeshRenderer>().material.color = c;
    }
    private void FixedUpdate()
    {
        if (valor2)
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
            valor2 = false;

        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
            valor2 = true;
        }
    }
}
