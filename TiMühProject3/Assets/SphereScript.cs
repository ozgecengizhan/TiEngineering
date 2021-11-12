using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    public float amplitude = 0.5f;
    public float timeCoeff = 2.8f;

    void Update()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        Vector3[] normals = mesh.normals;

        for (var i = 0; i < vertices.Length; i++)
        {
            vertices[i].y = amplitude * (Mathf.Sin(((Time.time) + Mathf.Sqrt(Mathf.Abs((vertices[i].z + 4) * (vertices[i].z + 4)) + ((vertices[i].x + 4) * (vertices[i].x + 4))))) + Mathf.Sin(((Time.time) + Mathf.Sqrt(Mathf.Abs((vertices[i].z - 4) * (vertices[i].z - 4)) + ((vertices[i].x - 4) * (vertices[i].x - 4)))))) * timeCoeff;
        }
        mesh.vertices = vertices;
    }

}