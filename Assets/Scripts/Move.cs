using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject camera;

    void Start()
    {
        Transform tr;//�̷��� Ʈ������ ���� �ʿ� ����.

        //���� ������Ʈ�� Ʈ�������� �ϴ��� �����̱� ������ ����Ƽ�� �⺻������ transform ������ �����Ѵ�.
        //�׷��� Ŭ���� Transform�� ����ϴ� �� ���� transform ������ ���� ����Ѵ�.

        //Vector3��?
        //ũ�� & ������ ���� ��
        //Scalar: ũ�⸸ ���� �� ex)int a = 4 ��
        //Vector3 vec1 = new Vector3(5, 0, 0);

        //transform.Translate(vec1);//Translate(): �ȿ� ���ڷ� ���� ���� ���� transform�� ������
    }
    void Update()
    {
        Vector3 v2 = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.Translate(v2);
        camera.transform.Translate(v2);
    }

}
