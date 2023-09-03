using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsulaOr : MonoBehaviour
{
    public Cubo cuboOr;
    public Esfera esferaOr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Debug.Log("Valor 1 esfera or " + cuboOr.valor1);
        Debug.Log("Valor 2 esfera or" + esferaOr.valor2);
        if (cuboOr.valor1 || esferaOr.valor2)
        {
            GetComponent<MeshRenderer>().material.color = Color.blue;

        }
    }
}
