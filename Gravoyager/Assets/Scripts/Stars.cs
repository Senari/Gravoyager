﻿using UnityEngine;
using System.Collections;

public class Stars : MonoBehaviour {




    void Start()
    {


    }
    // Update is called once per frame
    void Update () {

        MeshRenderer mr = GetComponent<MeshRenderer>();
        Material mat = mr.material;

        Vector2 offset = mat.mainTextureOffset;

        offset.x = PlayerScript.S.positionX / transform.localScale.x;
        offset.y = PlayerScript.S.positionY / transform.localScale.y;

        mat.mainTextureOffset = offset;
        
        

	}
}
