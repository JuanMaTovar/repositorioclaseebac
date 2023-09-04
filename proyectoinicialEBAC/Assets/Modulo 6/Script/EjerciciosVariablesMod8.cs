using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    int varInt = 0;
    float varFl = 1;
    float var1 = 2.2565f, var2 = 1.6f;
    int res;
    string flotaToString;


    // Start is called before the first frame update
    void Start()
    {

        //Utilizar el método substring para separar su nombre completo en 3 strings y utilizar el método Split para separar su nombre completo en una lista de strings.

        string miNombre = "Juan Manuel Tovar Sánchez";
        string nombre, apellido1, apellido2;
        nombre = miNombre.Substring(0, 11);
        apellido1 = miNombre.Substring(12, 5);
        apellido2 = miNombre.Substring(18, 7);
        Debug.Log("mi nombre es: " + nombre + " mi apellido paterno es: " + apellido1 + " mi apellido materno es: " + apellido2);
        string[] miNombreSplit = miNombre.Split(' ');
        Debug.LogWarning(miNombreSplit);

        //Crea dos variables string que guarden valores numéricos de miles, pasalas a tipos de datos 
        // numéricos utilizando la función tryParse, realiza una operación con ellas e imprime el resultado.

        string val1 = "5000";
        string val2 = "2000";
        int valEntero1, valEntero2;
        int.TryParse(val1, out valEntero1);
        int.TryParse(val2, out valEntero2);
        Debug.Log("Resultado" + valEntero1 * valEntero2);

        //Crea un string con una oración, imprime sólo los caracteres que se encuentren en un índice 
        //par, por ejemplo “Hola Mundo”, solo deberá imprimir los caracteres: H,l, ,u,d. (recuerda para qué sirve el uso del operador módulo).
        string oracion = "Curso de video juegos en unity";
        foreach (var i in oracion)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
        }

        //Crea un string guarda, una oración en él y elimina los primeros 5 caracteres de este ya sea 
        //con la función substring, Split, o cualquier otro método disponible en la clase String
        string oracion2 = "EBAC curso de Unity desde cero";
        Debug.Log(oracion2.Remove(0, 5));

        //Crea dos variables flotantes, has una operación entre ellas y obtén el resultado en un tipo de dato entero que requiera un casteo explícito.

        res = (int)(var1 * var2);
        Debug.Log("Resultado de 2.2565 x 1.6 = " + res);

        //Convertir un numero flotante a string e imprimir 4 posiciones de precisión (decimales)
        flotaToString = var1.ToString("0.0000");
        Debug.Log(flotaToString);

        //Utilizar un string y una sentencia switch y dependiendo de la palabra, el cubo deberá cambiar de color.
        string mystring = "rojo";
        switch (mystring)
        {
            case "negro":
                GetComponent<MeshRenderer>().material.color = Color.black;
                break;

            case "blanco":
                GetComponent<MeshRenderer>().material.color = Color.white;
                break;
            case "rojo":
                GetComponent<MeshRenderer>().material.color = Color.red;
                break;
            case "verde":
                GetComponent<MeshRenderer>().material.color = Color.green;
                break;
            default:
                Debug.LogError("No es un color valido");
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        //Crea dos variables: una variable de tipo entero que incremente su valor en cada frame y el segundo de tipo de float que se incremente en cada FixedUpdate utilizando el operador *=.

        Debug.Log("Valor entero: " + varInt++);
        varFl *= 0.1f;
        Debug.Log("Valor flotante: " + varFl);

        //Utiliza el operador módulo para saber si un número es impar o par y con el resultado modificar el GO de color en cada FixedUpdate.
        int valorRandom = Random.Range(1, 10);
        if (valorRandom % 2 == 0)
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}
