using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
//여기가 초기화 부분
    //게임 오브젝트 생성 시 최초로 실행되는 함수
    void Awake()
    {

        print("초기화");
    }
    //업데이트 시작 직전 최초로 실행됨
    void Start()
    {

        print("시작");
    }

//게임 오브젝트 활성화 지정 부분 얘가 start보다 먼저 출력됨
    void OnEnable()
    {

        print("로그인");
    }

    //물리연산 업데이트
    //1 초에 몇 번식 동작 => cpu부하 많이 잡아먹음
    void FixedUpdate()
    {

        print("고정적 업데이트");
    }

//게임 로직 영역
    void Update()
    {

        print("업데이트");
    }
    //애는 마지막 업데이트 
    void LateUpdate()
    {

        print("마지막 업데이트");
    }

//오브젝트 비활성화 지정 영역
    void OnDisable()
    {
        print("로그아웃");
        
    }


    //해체 영역
    //오브젝트 삭제 시 이렇게 됨 
    private void OnDestroy()
    {
        print("제거");

    }
}
