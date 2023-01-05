using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaTime : MonoBehaviour
{
    void Update()
    {
        //Time.deltaTime: 한 프레임에 사용된 시간
        //후진 컴퓨터 ==> 프레임이 적다 ==> 한 프레임에 소비하는 시간이 크다 ==> Time.deltaTime이 크다.
        //좋은 컴퓨터 ==> 프레임이 크다 ==> 한 프레임에 소비하는 시간이 작다 ==> Time.deltaTime이 작다.


        //Time.deltaTime 사용법
        //1. Translate ==> 매개변수 벡터 * Time.deltaTime
        //2. Vector.지원함수 ==> 매개변수 시간 값 * Time.deltaTime

    }
}
