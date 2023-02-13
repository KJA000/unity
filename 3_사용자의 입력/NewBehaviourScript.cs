using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//편집에서 프로젝트 편집 -> 입력 관리자를 통해 수동으로 설정도 가능
public class NewBehaviourScript : MonoBehaviour
{
    void Update()
    {
        //bool 타입 클래스임 유니티에서 기본적으로 제공 MonoBehaviour 에 있음
        if (Input.anyKeyDown) print("움직임");
       //bool 타입 꾹 누르고 있으면 값 반환하는 것
        //print(Input.anyKey);
        ///////////
        //Down : 눌렀을 때/ Stay : 꾹 누르고 있을 때/ UP : 누르고 뗐을 때

        //GetKey는 anykey 처럼 존나 많이 인식됨 계속 누르고 있는 상태로 인식됨
        if (Input.GetKey(KeyCode.LeftArrow)) print("왼쪽으로 이동 중");

        //이거 엔터키 지칭하는 것임
        if (Input.GetKeyDown(KeyCode.Return)) print("아이템 구매");

        //이거 esc 지칭하는 것임
        if (Input.GetKeyDown(KeyCode.Escape)) print("탈출");


        //얘는 한 번만 인식됨 
        if (Input.GetKeyUp(KeyCode.RightArrow)) print("오른쪽으로 이동");

        //마우스 인식은 GetMouse 로 시작함 좌클릭이 매개변수 0이고 우클릭은 1
        if (Input.GetMouseButtonDown(0)) print("마우스 좌클릭");

        if (Input.GetMouseButton(0)) print("마우스 꾹 클릭");

        if (Input.GetMouseButtonUp(1)) print("마우스 우클릭");

        //편집에서 프로젝트 편집 -> 입력 관리자를 통해 수동으로 설정도 가능
        //설정된 이름 문자열을 매개변수로 넣어주면 작동하는 방식임
        if (Input.GetButtonDown("Jump")) print("점프");

        //수평 수직 버튼 입력 시 float 횡 값 반환(가속도)
        //vertical도 가능
        if (Input.GetButtonDown("Horizontal")) print("횡 이동"+ Input.GetAxis("Horizontal"));

        //AxisRaw로 하면 왼쪽 오른쪽만 나타냄 왼 1 오 -1로
        if (Input.GetButtonDown("Horizontal")) print("횡 이동" + Input.GetAxisRaw("Horizontal"));


    }
}
