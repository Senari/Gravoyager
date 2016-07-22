using UnityEngine;
using System.Collections;

public class Stars : MonoBehaviour {


    public GameObject Obj;


    void Start()
    {
        
        
    }
    


    // Update is called once per frame
    void Update () {


        


        MeshRenderer mr = Obj.GetComponent<MeshRenderer>();
        Material mat = mr.material;

        Vector2 offset = mat.mainTextureOffset;

        //offset.x = PlayerScript.S.transform.position;

        mat.mainTextureOffset = offset;
        
        

	}
}
