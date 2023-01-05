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
        //C#���� ���׸��� & ���� ���� ���
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
            
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "MyBall")
        {
            mat.color = new Color(0, 0, 0);
            //�� ����
            //Color: �⺻ ���� ����
            //Color32: 255 ���� ����
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

