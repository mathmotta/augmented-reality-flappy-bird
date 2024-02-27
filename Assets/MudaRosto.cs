using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class MudaRosto : MonoBehaviour
{
    [SerializeField] Material[] _materiais;
    

    void Start()
    {
        var mesh = gameObject.GetComponent<ARFaceManager>().facePrefab.GetComponent<MeshRenderer>();
        var newMat = _materiais[Random.Range(0, _materiais.Length - 1)];
        var materiais = new Material[] { newMat };
        mesh.sharedMaterials = materiais;
        Debug.Log("material: " + mesh.sharedMaterials[0].name);
    }

}
