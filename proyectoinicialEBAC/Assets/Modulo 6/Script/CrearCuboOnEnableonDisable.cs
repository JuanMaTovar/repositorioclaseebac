using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCuboOnEnableonDisable : MonoBehaviour
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
    private void OnEnable()
    {
        GameObject temp = Instantiate<GameObject>(prefabCubo);
        temp.transform.position = new Vector3(3, 2, -13);
        temp.name = "Cubo OnEnable";

    }
    private void OnDisable()
    {
        
        GameObject temp = Instantiate<GameObject>(prefabCubo);
        temp.transform.position = new Vector3(6, 2, -13);
        temp.name = "Cubo OnDisable";

    }
}
