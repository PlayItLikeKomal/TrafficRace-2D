using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class road : MonoBehaviour
{
    public GameObject plane;
    public Renderer planerenderer;
    public float speed = 1f;
    public Vector2 offset;
    void Start()
    {
        planerenderer = plane.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        offset.y += -speed*Time.deltaTime;
        planerenderer.material.SetTextureOffset("_MainTex",offset);
    }
}
