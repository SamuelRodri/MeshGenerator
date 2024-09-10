using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class MeshGenerator : MonoBehaviour
{
    private MeshFilter _meshFilter;
    private MeshRenderer _meshRenderer;

    private void Awake()
    {
        _meshFilter = GetComponent<MeshFilter>();
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnEnable()
    {
        // We create the mesh
        var mesh = new Mesh()
        {
            name = "Procedural Mesh"
        };

        // We create the vertices
        mesh.vertices = new Vector3[]
        {
            Vector3.zero, Vector3.right, Vector3.up
        };

        // We define the indices
        mesh.triangles = new int[]
        {
            0, 2, 1
        };

        // We assign the mesh to the mesh filter
        _meshFilter.mesh = mesh;
    }
}
