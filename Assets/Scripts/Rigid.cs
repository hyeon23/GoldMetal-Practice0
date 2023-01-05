using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rigid : MonoBehaviour
{
    Rigidbody rigid;
    //transform.position�� ���� �̵��� Rigidbody�� �̿��� �̵��� ����
    //rigidbody�� �̿��� �̵��� �� �� �ڿ�������.

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        //AddForce ���� 1: �ȿ� Vector3�� �־��ֱ�

        //1. ForceMode.Impulse: ���Կ� ������ ����
        //2.
        //3.
        //4.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        //rigitbody ���� ������ update���� fixed update�� �ۼ�
        //#1 �ӷ� �ٲٱ�
        //rigid.velocity = new Vector3(2, 4, 3);//Rigidbody.velocity: ���� �̵��ӵ�

        //#2 �� �����ֱ�(AddForce)
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 25, ForceMode.Impulse);//ĳ���� Jump�� �����ϴ� �ֿ� �ڵ�
                                                              //���� ���� Ŭ ���� ������ �� ���� ���� �ʿ��ؼ� ����� �ö��� �ʴ´ٸ� ������Ʈ�� Mass���� Ȯ��
        }

        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        rigid.AddForce(vec, ForceMode.Impulse);

        //#3 ȸ���� �ֱ�(AddTorque)
        rigid.AddTorque(Vector3.up);   

    }
    //Oncollision�Լ� ����

    //void OnCollisionStay(Collision collision)
    //{
    //    if (collision.gameObject.name == "cucu")
    //    {
    //        rigid.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
    //    }
    //}
    //OnTrigger�Լ� ����

    private void OnTriggerStay(Collider other)//�������� ��� collision�� �ƴ� collider�� ���ƴ����� Ȯ���ϱ� ������ ���
    {
        if(other.gameObject.name == "cucu")
        {
            rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
    }

    public void Jump()
    {
        rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }
}