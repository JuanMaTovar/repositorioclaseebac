using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola Mundo desde la funci�n Start()");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogWarning("Hola Mundo desde la funci�n Update()");
    }
    private void Awake()
    {
        Debug.LogError("Hola Mundo desde la funci�n Awake()");
    }
    private void FixedUpdate()
    {
        Debug.Log("Hola Mundo desde la funci�n FixedUpdate()");
    }
    private void LateUpdate()
    {
        Debug.LogWarning("Hola Mundo desde la funci�n LateUpdate()");
    }
}
