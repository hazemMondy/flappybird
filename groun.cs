using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groun : MonoBehaviour
{
    private Renderer rend;
    private float scrollSpeed=5f;

    private void Awake()
    {
        rend = GetComponent<Renderer>();   
    }
    
    void Update()
    {
        Vector2 CurrentTextureOffset = rend.material.GetTextureOffset("_MainTex");
        float distanceToScrollLeft = Time.deltaTime * scrollSpeed;
        float newXOffset = CurrentTextureOffset.x + distanceToScrollLeft;
        Vector2 newOffest = new Vector2(newXOffset, CurrentTextureOffset.y);
        rend.material.SetTextureOffset("_MainTex", newOffest);
    }
}
