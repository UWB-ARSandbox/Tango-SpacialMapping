using System.Collections;
using System.Collections.Generic;
using Tango;
using UnityEngine;

public class MeshManager : MonoBehaviour {
    public void ExportMesh() {
        List<Vector3> vertices = new List<Vector3>();
        List<Vector3> normals = new List<Vector3>();
        List<Color32> colors = new List<Color32>();
        List<int> triangles = new List<int>();

        gameObject.GetComponent<TangoApplication>()
            .Tango3DRExtractWholeMesh(vertices, normals, colors, triangles);
    }
}
