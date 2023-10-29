using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgRepeat : MonoBehaviour
{
    private Renderer m_Renderer;

    [SerializeField] private float scrollSpeed;
    // Start is called before the first frame update
    void Start()
    {
        m_Renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Scroll();
    }

    void Scroll()
    {
        Vector2 textureOffset = new Vector2(Time.time * scrollSpeed, 0);
        m_Renderer.material.mainTextureOffset = textureOffset;
    }
}
