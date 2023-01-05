using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    GameObject myBall;
    MeshRenderer mesh;
    Material mat;

    // Start is called before the first frame update
    void Start()
    {
        //C#에서 매테리얼 & 색깔 접근 방법
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
            
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "MyBall")
        {
            mat.color = new Color(0, 0, 0);
            //색 변경
            //Color: 기본 색상 변경
            //Color32: 255 색상 변경
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.name == "MyBall")
        {
            mat.color = new Color(1, 1, 1);
        }    
    }
}

