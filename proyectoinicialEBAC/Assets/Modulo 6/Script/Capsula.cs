using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsula : MonoBehaviour
{   //Creamos variables del tipo del objeto para poder entrar a sus valores
    public Cubo cubo;
    public Esfera esfera;
    
    
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
        
        //muestro en consola el contenido de las variables
        Debug.Log("valor 1 " + cubo.valor1);
        Debug.Log("valor 2 " + esfera.valor2);
        //Se evalua el contenido de las variables booleanas en caso de cumplir entra a la condición
        //en este caso nunca entrara a la condición ya que valor 1 es true y valor 2 es false
        if (cubo.valor1 && esfera.valor2)
        {
            GetComponent<MeshRenderer>().material.color = Color.red;

        }
       
        
        //Color c = new Color(Random.value, Random.value, Random.value);
        ////se le asigna el color al objeto
        //GetComponent<MeshRenderer>().material.color = c;

    }
}
