using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseKeyBoardInput : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //키보드 & 마우스 입력
        //1. Input: 게임 내 입력을 관리해주는 클래스
        if (Input.anyKeyDown)//Input.anyKeyDown: 최초의 입력(마우스 & 키보드)을 받을 시 활성화
        {
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");
        }
        if (Input.anyKey)//Input.anyKey
        {
            Debug.Log("플레이어가 아무 키를 누르고 있습니다.");
        }
        //일반적으로 Down이 붙은 키워드와 없는 키워드의 차이는 이러하다

        //키보드 입력
        //GetKey: 키보드 버튼 입력을 받으면 true
        //Down & Stay & Up 으로 구성
        if (Input.GetKeyDown(KeyCode.Return)) // =Enter KeyCode.Enter가 없다.
        {
            Debug.Log("아이템을 구입했습니다.");
        }
        if (Input.GetKeyDown(KeyCode.Escape)) // =ESC KeyCode.ESC가 없다.
        {
            Debug.Log("환경설정");
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("왼쪽으로 이동 중");
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Debug.Log("오른쪽으로 이동 중");
        }

        //마우스 입력
        //GetMouseButton
        //Down & Stay & Up으로 구성
        //0: 마우스 왼쪽 버튼
        //1: 마우스 오른쪽 버튼
        if (Input.GetMouseButtonDown(0))
            Debug.Log("미사일 발사!");
        if (Input.GetMouseButton(0))
            Debug.Log("미사일 모으는 중");
        if (Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사");

        //입력방식 3
        //Input Manager를 통한 입력
        if (Input.GetButtonDown("Jump"))//GetButton은 InputManager의 이름 값을 문자열으로 작성해준다.
            Debug.Log("점프!");
        if (Input.GetButton("Jump"))
            Debug.Log("점프 모으는 중...");
        if (Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼 점프!!!");
        //횡이동
        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("횡 이동 중..." + Input.GetAxis("Horizontal"));//수평, 수직 입력을 받으면 누른 크기만큼 flaot 반환
            //-0.0... ~ -1까지 or 0.0 ~ 1까지
            //점진적으로 증가 ==> 가속도의 효과

            //가속도가 필요 없다면
            Debug.Log("횡 이동 중..." + Input.GetAxisRaw("Horizontal"));// 1, -1의 float 값 출력
            //2개 키 동시에 입력시 0
        }
        //종이동
        if (Input.GetButton("Vertical"))
        {
            Debug.Log("종 이동 중..." + Input.GetAxis("Vertical"));//수평, 수직 입력을 받으면 누른 크기만큼 flaot 반환
            //가속도가 필요 없다면
            Debug.Log("종 이동 중..." + Input.GetAxisRaw("Vertical"));// 1, -1의 float 값 출력
            //2개 키 동시에 입력시 0
        }

    }
}
