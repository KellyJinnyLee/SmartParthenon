using System.Linq;
using UnityEngine;

public class ParthenonBuilder : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject cylinderPrefab;
    public float floorWidth = 5.0f;
    public float floorDepth = 10.0f;
    public float floorHeight = 0.25f;
    public float pillarRadius = 0.2f;
    public float pillarHeight = 2.0f;
    public float pillarCountWidth = 6.0f;
    public float pillarCountDepth = 10.0f;
    public float roofHeight = 1f;
    public Material floorMaterial;
    public Material pillarMaterial;
    public Material roofMaterial;

    [ContextMenu("Build")]
    void BuildPrefab()
    {

        DestroyAll();

        var newGameobject = Instantiate(cubePrefab, transform);
        var tr = newGameobject.transform;
        tr.localScale = new Vector3(floorWidth, floorHeight, floorDepth);
        tr.position = new Vector3(0, 0, 0);

        var newGameobject2 = Instantiate(cubePrefab, transform);
        var tr2 = newGameobject2.transform;
        tr2.localScale = new Vector3(floorWidth * 0.9f, floorHeight, floorDepth * 0.9f);
        tr2.position = new Vector3(0, floorHeight, 0);

        var newGameobject3 = Instantiate(cubePrefab, transform);
        var tr3 = newGameobject3.transform;
        tr3.localScale = new Vector3(floorWidth * 0.9f * 0.9f, floorHeight, floorDepth * 0.9f * 0.9f);
        tr3.position = new Vector3(0, floorHeight*2f, 0);

        var newGameobject4 = Instantiate(cylinderPrefab, transform);
        var tr4 = newGameobject4.transform;
 
    }

    [ContextMenu("Destroy All")]
    void DestroyAll()
    {
        foreach (Transform t in transform.Cast<Transform>().ToArray())
        {
            DestroyImmediate(t.gameObject);
        }
    }
}
