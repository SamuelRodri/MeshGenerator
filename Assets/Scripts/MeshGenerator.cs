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
        Mesh mesh = new Mesh()
        {
            name = "Procedural Mesh"
        };

        // We assign the mesh to the mesh filter
        _meshFilter.mesh = mesh;
    }
}
