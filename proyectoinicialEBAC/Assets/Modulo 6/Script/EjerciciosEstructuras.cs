using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosEstructuras : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        //FuncionLista(20, 1, 20);
        //FuncionDescentente(5,1,10);
        //FuncionHashSet(10, 1, 10);
        FuncionPilasColas();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Lista con valores inferior superios
    public List<int> FuncionLista(int tamaño, int rangoInf, int rangoSup)
    {
        List<int> listaNumeros1 = new List<int>();
        for (int i = 0; i <tamaño; i++)
        {
            listaNumeros1.Add(Random.Range(rangoInf, rangoSup));
        }
        foreach (var numero in listaNumeros1)
        {
            Debug.Log(numero);
        }
        return listaNumeros1;
    }
    //Ordenar los numeros de manera descente
    public List<int> FuncionDescentente(int tamaño, int rangoInf, int rangoSup)
    {
        List<int> listaNumeros2 = new List<int>();
        for (int i = 0; i < tamaño; i++)
        {
            listaNumeros2.Add(Random.Range(rangoInf, rangoSup));
        }
        listaNumeros2.Sort();
        listaNumeros2.Reverse();
        foreach (var numero in listaNumeros2)
        {
            Debug.Log(numero);
        }
        return listaNumeros2;
    }
   //HashSet sin numeros repetidos
    public HashSet<int> FuncionHashSet(int tamaño, int rangoInf, int rangoSup)
    {
        HashSet<int> hashSetNum = new HashSet<int>();
        for (int i = 0; i < tamaño; i++)
        {
            hashSetNum.Add(Random.Range(rangoInf, rangoSup));
        }
        foreach (var numero in hashSetNum)
        {
       
            Debug.Log(numero);
        }

        return hashSetNum;
    }
    //Pilas y colas LiLo
    public void FuncionPilasColas()
    {//Pilas
       
        Stack<string> pilaStrings = new Stack<string>();
        for(int i = 0; i <6; i++)
        {
            pilaStrings.Push("dato " + i);
            Debug.Log(pilaStrings.Peek());
            pilaStrings.Pop();

        }
       

        //Colas FiLo
        Queue<string> colaString = new Queue<string>();
        for (int i = 0; i < 6; i++)
        {
            colaString.Enqueue("dato " + i);
            Debug.Log(colaString.Peek());
            colaString.Dequeue();

        }

    }
   
}
