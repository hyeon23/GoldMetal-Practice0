using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transportation : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);


    void Update()
    {
        //1. MoveTowards: 등속이동 함수
        //매개변수 (Vector3 현재 위치, Vector3 목표 위치, 속도)//속도가 클 수록 빨라짐
        transform.position = Vector3.MoveTowards(transform.position, target, 1f * Time.deltaTime);

        //2. SmoothDamp: 부드러운 감속 이동
        Vector3 velo = Vector3.zero;
        //SmoothDamp 사용시 velo는 보통 zero로 고정한다. 아닐 시 목표 지점의 의미를 상실하게 됨
        transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f * Time.deltaTime);//마지막 인자 값이 작을 수록 빨라짐
        //ref: 신경x 너무 어려운 이론

        //3. Lerp: 선형 보간, SmoothDamp보다 감속을 길게 함
        transform.position = Vector3.Lerp(transform.position, target, 0.1f * Time.deltaTime);//사용법은 MoveToward와 동일
                                                                          //1이 max값, 0.5는 중간, 0.0000...1이 시작 값

        //4. Slerp(구면 선형 구간): 포물선을 그리며 이동
        transform.position = Vector3.Slerp(transform.position, target, 0.1f * Time.deltaTime);
    }
}
