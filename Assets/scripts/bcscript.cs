using UnityEngine;

public class bcscript : MonoBehaviour
{
 public float scrollSpeed = 0.5f;
    private MeshRenderer Mesh_renderer;

    void Awake()
    {
        Mesh_renderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        scroll();
    }
    void scroll()
    {
        Vector2 offset = Mesh_renderer.sharedMaterial.GetTextureOffset("_MainTex");
        offset.y += scrollSpeed * Time.deltaTime;
        Mesh_renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
