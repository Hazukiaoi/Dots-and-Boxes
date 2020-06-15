using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxObject : MonoBehaviour
{
    public MeshRenderer meshRenderer;

    Material material;

    public void Init()
    {
        material = meshRenderer.material;
    }
    public void SetColor(Color c)
    {
        material.SetColor("_BaseColor", c);
    }

}
