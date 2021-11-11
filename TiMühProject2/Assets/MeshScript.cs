using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshScript : MonoBehaviour
{
    public float amplitude = 0.1f;
    public float timeCoeff = 0.1f;
    void Update()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        Vector3[] normals = mesh.normals;

        for (var i = 0; i < vertices.Length; i++)
        {
            vertices[i].y = amplitude * Mathf.Sin(((Time.time) + Mathf.Sqrt(Mathf.Abs(vertices[i].z * vertices[i].z) + (vertices[i].x * vertices[i].x))) * timeCoeff);
        }

        mesh.vertices = vertices;
    }

}