using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b3 : MonoBehaviour
{
    // Start is calleD before the first frame update
    void Start()
    {
        Debug.Log("Hello unity");


        // 자주 쓰는 변수 4가지 :  int(정수형 데이터), float(숫자형 데이터), string(문자열 데이터), bool(O/X)
        // 변수 끝에는 항상 ; (세미콜론) 붙여주기
        // 변수 이름 정하는건 변수 선언, 변수에 값을 주는 건 초기화라고 함
        //프로그램은    선언 > 초기화 > 호출(사용)      으로 흘러감
        
    
        //1.변수
        
        int level = 5;
        float strength = 15.5f;
        string playerName = "궁수";
        bool isFullLevel = false;


        Debug.Log("용사의 이름은?");
        Debug.Log(playerName);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);
        Debug.Log("용사는 만랩인가?");
        Debug.Log(isFullLevel);


        //2.그룹형 변수
        //중괄호 사용한 초기화
        //   유형[] 그룹변수이름 = {"중괄호", "안에", "값을", "적어", "초기화"}
        string[] monsters = {"슬라임", "미라", "사막뱀", "전갈", "개미귀신"};  
        // Debug.Log("맵에 존재하는 몬스터");
        // Debug.Log(monsters[0]);
        // Debug.Log(monsters[1]);
        // Debug.Log(monsters[2]);
        // Debug.Log(monsters[3]);
        // Debug.Log(monsters[4]);

        //길이주고 초기화({}중괄호사용 안함)
        int[] monsterLevel = new int[5]; //변수?의 개수를 적음 0~4까지면 5 입력
        monsterLevel[0] = 1;
        monsterLevel[1] = 5;
        monsterLevel[2] = 15;
        monsterLevel[3] = 66;
        monsterLevel[4] = 20;

        Debug.Log("맵에 있는 몬스터 레벨");
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);
        Debug.Log(monsterLevel[3]);
        Debug.Log(monsterLevel[4]);

        //변수 끝, 리스트 시작
        //리스트
        //List<자료형> items = new List<자료형>();    <-이걸 제네릭???뭐라는 거야?
        List<string> items = new List<string>();
        items.Add("HP30");
        items.Add("MP30");
        items.Add("빵");
        items.Add("화살");


        //List는 자료 삭제 가능
        items.RemoveAt(3);
        items.Add("작살");


        Debug.Log("가지고 있는 아이템");
        Debug.Log(items[0]);
        Debug.Log(items[1]);
        Debug.Log(items[2]);
        Debug.Log(items[3]);


        //3. 연산자
        int exp = 1500; //경험치

        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        Debug.Log("용사의 총 경험치는?");
        Debug.Log(exp);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);

        int nexExp = 300 - (exp % 300);  // % 는 나머지
        Debug.Log("다음 레벨까지 남은 경험치는?");
        Debug.Log(nexExp);

        string title = "전설의";
        Debug.Log("용사의 이름은?");
        Debug.Log(title + " " + playerName);



        int FullLevel = 99;
        isFullLevel = level ==FullLevel;
        Debug.Log("용사는 만렙입니까?" + isFullLevel);







    }
}
