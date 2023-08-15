using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCuboAwake : MonoBehaviour
{
    GameObject objToSpawn;
    Vector3[] vertices =
    {
        new Vector3(0,0,0), //vertice 0
        new Vector3(1,0,0), //vertice 1
        new Vector3(1,1,0), //vertice 2
        new Vector3(0,1,0), //vertice 3
        new Vector3(0,1,1), //vertice 4
        new Vector3(1,1,1), //vertice 5
        new Vector3(1,0,1), //vertice 6
        new Vector3(0,0,1), //vertice 7
    };

    int[] triangulos =
    {
        0,2,1, //cara 1
        0,3,2,
        2,3,4, //cara 2
        2,4,5,
        1,2,5, //cara 3
        1,5,6,
        0,7,4, //cara 4
        0,4,3,
        5,4,7, //cara 5
        5,7,6,
        0,6,7, //cara 6
        0,1,6
    };
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
        objToSpawn = new GameObject("Cubo desde Awake");
        objToSpawn.AddComponent<MeshFilter>();
        var meshFilter = objToSpawn.GetComponent<MeshFilter>().mesh;
        meshFilter.Clear();
        meshFilter.vertices = vertices;
        meshFilter.triangles = triangulos;
        meshFilter.Optimize();
        meshFilter.RecalculateNormals();
        objToSpawn.AddComponent<BoxCollider>();
        var boxCollider = objToSpawn.GetComponent<BoxCollider>();
        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);
        objToSpawn.AddComponent<MeshRenderer>();
        var meshRendererMaterial = objToSpawn.GetComponent<MeshRenderer>().material;
        meshRendererMaterial.color = Color.white;
        objToSpawn.transform.position = new Vector3(4, 1, -13);
    }
}
