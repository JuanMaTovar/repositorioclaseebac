using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCuboAwake : MonoBehaviour
{
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
      GameObject temp = Instantiate<GameObject>(prefabCubo);
        temp.transform.position = new Vector3(0,2,-13);
        temp.name = "Cubo Awake";
              
    }
}
