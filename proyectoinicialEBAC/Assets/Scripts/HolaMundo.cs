using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola Mundo desde la función Start()");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogWarning("Hola Mundo desde la función Update()");
    }
    private void Awake()
    {
        Debug.LogError("Hola Mundo desde la función Awake()");
    }
    private void FixedUpdate()
    {
        Debug.Log("Hola Mundo desde la función FixedUpdate()");
    }
    private void LateUpdate()
    {
        Debug.LogWarning("Hola Mundo desde la función LateUpdate()");
    }
}
