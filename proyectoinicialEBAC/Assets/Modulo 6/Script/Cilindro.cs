using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cilindro : MonoBehaviour
{
    public Cubo cuboCil;
    public Esfera esfCil;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cuboCil.valor1 || esfCil.valor2){
            GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }
}
