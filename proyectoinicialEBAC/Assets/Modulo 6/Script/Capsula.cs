using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsula : MonoBehaviour
{
    //creamos un objeto de tipo GameObject
    public GameObject prefabCapsula;
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
        Color c = new Color(Random.value, Random.value, Random.value);
        //se le asigna el color al objeto
        prefabCapsula.GetComponent<MeshRenderer>().material.color = c;
    }
}
