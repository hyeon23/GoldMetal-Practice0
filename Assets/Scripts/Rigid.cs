using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rigid : MonoBehaviour
{
    Rigidbody rigid;
    //transform.position을 통한 이동과 Rigidbody를 이용한 이동의 차이
    //rigidbody를 이용한 이동은 좀 더 자연스럽다.

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        //AddForce 사용법 1: 안에 Vector3를 넣어주기

        //1. ForceMode.Impulse: 무게에 영향을 받음
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
        //rigitbody 관련 내용은 update보다 fixed update에 작성
        //#1 속력 바꾸기
        //rigid.velocity = new Vector3(2, 4, 3);//Rigidbody.velocity: 현재 이동속도

        //#2 힘 더해주기(AddForce)
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 25, ForceMode.Impulse);//캐릭터 Jump를 구현하는 주요 코드
                                                              //무게 값이 클 수록 점프에 더 많은 힘이 필요해서 실행시 올라가지 않는다면 오브젝트의 Mass값을 확인
        }

        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        rigid.AddForce(vec, ForceMode.Impulse);

        //#3 회전력 주기(AddTorque)
        rigid.AddTorque(Vector3.up);   

    }
    //Oncollision함수 사용법

    //void OnCollisionStay(Collision collision)
    //{
    //    if (collision.gameObject.name == "cucu")
    //    {
    //        rigid.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
    //    }
    //}
    //OnTrigger함수 사용법

    private void OnTriggerStay(Collider other)//물리적인 충격 collision이 아닌 collider가 겹쳤는지만 확인하기 때문에 사용
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