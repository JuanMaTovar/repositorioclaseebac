using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosdeCiclosyarreglos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //punto 1 módulo 9
        int[] vectorEnt1 = new int[5]; // {1,2,3,4,5};
        int[] vectorEnt2 = new int[5]; //{1,2,3,4,5};
        int[] vectorRes = new int[5];

        for (int i = 0; i < vectorEnt1.Length; i++)
        {
            vectorEnt1[i] = Random.Range(1, 10);
            vectorEnt2[i] = Random.Range(1, 10);
            vectorRes[i] = vectorEnt1[i] + vectorEnt2[i];
            Debug.Log(vectorRes[i]);
        }

        //punto 2 módulo 9
        string[] vectorStr = new string[3] { "hola ", "mundo ","Unity" };
        string oracion = null;
        foreach (string i in vectorStr)
        {
            //oracion = string.Join(",", vectorStr);
            oracion += i;
        }
        Debug.LogWarning(oracion);

        //punto 3 módulo 9
        int[,] arregloEnt3 = new int[2, 3] { {1,2,3},{4,5,6} };
        int[] vectorEnt3 = new int[3] {7,8,9};
        int[] vectorRes2 = new int[3];
        int suma = 0;

        for (int j=0; j < arregloEnt3.GetLength(0); j++)
        {
            for (int k=0; k < arregloEnt3.GetLength(1); k++)
            {
                suma +=  arregloEnt3[j, k] * vectorEnt3[k];
            }
            vectorRes2[j] = suma;
            suma = 0;
            Debug.LogWarning(vectorRes2[j]);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
