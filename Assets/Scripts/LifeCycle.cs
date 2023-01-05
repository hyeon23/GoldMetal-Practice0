using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    //1 초기화 영역 = Awake + Start
    void Awake()//: 게임 오브젝트가 생성 시, 최초로 한 번만 실행
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    void OnEnable()//오브젝트 활성화 비활성화 개념
    //오브젝트가 활성화 시 실행
    {//최초 1회 실행이 아닌 오브젝트가 enable하게 되는 최초 1회 실행
    //활성화란 유니티 에디터의 눈 표시를 키고 끄는 것을 말함
        Debug.Log("플레이어가 로그인 했습니다.");
    }

    void Start()//: 업데이트 시작 직전 최초로 한 번만 실행
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    //2 물리 연산 영역 = FixedUpdate[프레임]
    void FixedUpdate()//: 물리연산을 하기 전에 실행되는 업데이트 함수
    {//1초에 고정된 실행 주기(약 50회)로 여러 번 호출해 CPU 부하가 많다.
        //그래서 이 안에는 물리 연산과 관련된 로직만 놓음
        Debug.Log("이동~");
    }
    //3 게임 로직 영역 = Update + LateUpdate[프레임]
    void Update()//물리 연산을 제외한 주기적으로 변하는 로직을 넣을 때 사용하는 함수
    {//환경에 따라 실행 주기가 변경된다.
        Debug.Log("몬스터 사냥!!");
    }
    void LateUpdate()//: 모든 업데이트 후 마지막으로 호출되는 업데이트
    {//캐릭터를 따라가는 카메라 & 로직의 후처리 등
        Debug.Log("경험치 획득");
    }
    void OnDisable()
    {
        Debug.Log("플레이어가 로그 아웃 했습니다.");
    }
    //4 해체
    void OnDestroy()//: 게임 오브젝트가 삭제되기 직전에 실행
    {
        Debug.Log("플레이어 데이터를 해체합니다.");
    }

}
