
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MaterialInstance : MonoBehaviour
{
    public GameObject _object;
    public Material material;

    public Texture texture;
    public MeshRenderer render;

    void Start()
    {
        _object = this.gameObject;
        render = GetComponent<MeshRenderer>();
        //material = _object.GetComponent<MeshRenderer>().material;
    }
    void Update()
    {
        render.material.mainTexture = texture;
    }



}
