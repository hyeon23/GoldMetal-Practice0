using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour//public class
    //10. 상속
    //배우가 용사일수도 슬라임일수도 악마일수도
    //배우라는 클래스를 가지고 또 다른 클래스를 만들 수 있다.
    //MonoBehaviour: 유니티 게임 오브젝트 클래스
{
    //전역변수
    string title = "전설의";
    string playerName = "나검사";
    int level = 5;
    float strength = 15.5f;
    int exp = 1500;
    int health = 30;
    int mana = 25;
    bool isFullLevel = false;

    void Start()
    {
        //0. 시작
        //Debug.Log("Hello Unity!");
        //===========================================================================
        //1. 변수 = 전역변수 + 지역변수
        //int, float[f 사용 필수], string, bool 사용
        //선언 + 초기화로 구성
        //선언 >> 초기화 >> 호출 순으로 작동
        //===========================================================================
        //Debug.Log("용사의 이름은?");
        //Debug.Log(playerName);
        //Debug.Log("용사의 레벨은?");
        //Debug.Log(level);
        //Debug.Log("용사의 힘은?");
        //Debug.Log(strength);
        //Debug.Log("용사는 만랩인가?");
        //Debug.Log(isFullLevel);
        //===========================================================================
        ////2. 배열 사용 방법
        ////배열: 그룹형 변수
        string[] monsters = { "슬라임", "사막뱀", "악마" };
        int[] monstersLevel = new int[3];
        monstersLevel[0] = 1;
        monstersLevel[1] = 10;
        monstersLevel[2] = 99;
        //Debug.Log("맵에 존재하는 몬스터");
        //Debug.Log(monsters[0]);
        //Debug.Log(monsters[1]);
        //Debug.Log(monsters[2]);
        //Debug.Log("맵에 존재하는 몬스터 레벨");
        //Debug.Log(monstersLevel[0]);
        //Debug.Log(monstersLevel[1]);
        //Debug.Log(monstersLevel[2]);
        //===========================================================================
        //3. 리스트 사용법
        //리스트: 기능이 추가된 가변형 그룹형 변수
        //배열과는 다르게 삭제 가능
        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("생명물약60");
        Debug.Log(items[0]);
        Debug.Log(items[1]);

        items.RemoveAt(1);//리스트의 해당 index 내용물을 삭제하고 앞으로 댕겨주는 것
        Debug.Log(items[0]);
        //===========================================================================
        //4. 연산자
        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;
        int nextExp = 300 - (exp % 300);

        Debug.Log("용사의 이름은?");
        Debug.Log(title + " " + playerName);
        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        Debug.Log("용사는 만랩입니까?" + isFullLevel);
        bool isEndTutorial = level >= 10;
        Debug.Log("튜토리얼이 끝난 용사입니까?" + isEndTutorial);

        bool isBadCondition = health <= 50 && mana <= 20; // &&: and, ||: or, ~: not
        Debug.Log("용사의 상태가 나쁩니까?" + isBadCondition);

        string condition = isBadCondition ? "나쁨" : "좋음";//? 참 : 거짓 값 대입
        //===========================================================================
        //5. 키워드: 프로그래밍 언어를 구성하는 특별한 의미가 담겨진 언어 ex int, float, string, bool, new, List 등
        //-변수 이름 or 값으로 사용 불가
        //===========================================================================
        //6. 조건문: if / else if / for
        if (condition == "나쁨")
        {
            Debug.Log("플레이어의 상태가 나쁘니 아이템을 사용하세요");
        }
        else
        {
            Debug.Log("플레이어의 상태가 좋습니다.");
        }
        if(isBadCondition && items[0] == "생명물약30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("생명포션30을 사용했습니다.");
        }
        else if(isBadCondition && items[0] == "마나물약30")
        {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("마나포션30을 사용했습니다.");
        }
        switch (monsters[0])
        {
            case "슬라임":
            case "사막뱀":
                Debug.Log("소형 몬스터가 출현!");
                break;
            case "악마":
                Debug.Log("중형 몬스터가 출현!");
                break;
            case "골렘":
                Debug.Log("대형 몬스터가 출현!");
                break;
            default://모든 case문을 실행하지 못했을 때 마지막으로 실행되는 구간
                Debug.Log("알 수 없는 크기");
                break;
        }
        //===========================================================================
        //7. 반복문 (while / for)
        while (health > 0)//독 도트뎀 활용
        {
            health--;
            if (health > 0)
                Debug.Log("독 데미지를 입었습니다. " + health);
            else
                Debug.Log("사망하셨습니다.");
            if(health == 10)
            {
                Debug.Log("해독제를 사용합니다.");
                break;
            }
        }
        for(int count = 0; count < 10; count++)
        {
            health++;
            Debug.Log("붕대로 치료 중..." + health);
        }
        //for문의 최대 장점은 그룹형 변수의 활용에 있다.

        for(int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("이 지역의 몬스터 : " + monsters[index]);
        }

        foreach (string monster in monsters)//for문의 진화된 버전
        {
            Debug.Log("이 지역의 몬스터 : " + monster);
        }
        //8. 함수(method)
        health = Healing(health);
        Heal();
        for (int i = 0; i < monsters.Length; i++)
        {
            Debug.Log("용사는" + monsters[i] + "에게" + Battle(monstersLevel[i]));
        }
        //===========================================================================

        //9. 클래스
        //하나의 사물(=오브젝트)에 대응하는 묶음
        //10. 상속도 함께 사용
        Actor a = new Actor();
        Player player = new Player();//클래스를 하나의 변수로 만듬 ==> 인스턴스화
        player.id = 0;
        player.name = "나법사";
        player.title = "현명한";
        player.strength = 2.4f;
        player.weapon = "나무 지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.name + "의 레벨은 " + player.level + "입니다.");


    }
    //8. 함수(method)
    int Healing(int currentHealth)
    {
        currentHealth += 10;
        Debug.Log("힐을 받았습니다. " + currentHealth);
        return currentHealth;
    }

    void Heal()//반환 데이터가 없는 타입의 메소드
    {
        health += 10;
        Debug.Log("힐을 받았습니다. " + health);
        //health를 못 쓴다. Start안에서 정의된 것이기 때문이다. 
        //health는 Start 함수의 지역 변수이기 때문이다. => 다른 함수에서 지역변수 접근 불가능
        //모든 함수가 자유롭게 변수를 사용할 수 있게 하기 위한 방법 => 전역변수 선언: 변수를 가장 위쪽에 선언
    }
    string Battle(int monsterLevel)
    {
        string result;
        if(level >= monsterLevel)
        {
            result = "win";
        }
        else
        {
            result = "lose";
        }
        return result;
    }
    //===========================================================================
}
