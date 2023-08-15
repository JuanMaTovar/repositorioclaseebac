using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    //creamos un objeto de tipo GameObject
    public GameObject prefabCubo;
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
        prefabCubo.GetComponent<MeshRenderer>().material.color = c;

    }
}
