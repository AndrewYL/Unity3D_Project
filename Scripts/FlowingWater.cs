using UnityEngine;

public class FlowingWater : MonoBehaviour
{
    public float speed = 0.1f;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        float offset = Time.time * speed;
        rend.material.mainTextureOffset = new Vector2(offset, 0);
    }
}