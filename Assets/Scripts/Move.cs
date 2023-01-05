using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject camera;

    void Start()
    {
        Transform tr;//이렇게 트랜스폼 만들 필요 없다.

        //게임 오브젝트와 트랜스폼은 일대일 관계이기 때문에 유니티가 기본적으로 transform 변수가 존재한다.
        //그래서 클래스 Transform을 사용하는 것 보다 transform 변수를 많이 사용한다.

        //Vector3란?
        //크기 & 방향을 가진 값
        //Scalar: 크기만 가진 값 ex)int a = 4 등
        //Vector3 vec1 = new Vector3(5, 0, 0);

        //transform.Translate(vec1);//Translate(): 안에 인자로 들어가는 벡터 값을 transform에 더해줌
    }
    void Update()
    {
        Vector3 v2 = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.Translate(v2);
        camera.transform.Translate(v2);
    }

}
