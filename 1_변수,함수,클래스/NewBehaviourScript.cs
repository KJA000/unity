using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public
      //여기에 선언하는 모든 게 전역 변수임 

      string[] m = { "a", "b", "c" };
    //배열 사용법
    /*
    int[] a = new int[3];
    //배열 동적할당

    List<int> im = new List<int>(2);
    //리스트 자료형
    List<string> jm = new List<string>();
    */
    mynewclass mnc = new mynewclass();
    void Start()
    {
        /* 
         im.Add(4);
         im.Add(5);
         //리스트 자료형은 이런 식으로 데이터 추가함 
         //배열은 텅 비어 있을 때 정수형의 경우 0 나옴'
         for(int i=0;i<im.Count;i++)
         {
             print("나는 im[i]값이다");
             print(im[i]);
             print("나는 i값이다");
             print(i);
         }
         im[1] = 3;
         //근데 이런 식으로 이미 add한 경우에는 배열처럼 인덱스 사용해서 값 할당 가능

         im.RemoveAt(1);
         //아이템 삭제 가능 이 경우 인덱스 에러 발생

         print("나는 " + "바보다");
         //콘솔에 뭔가 출력할 경우 + 기호 사용해서 여러 개 출력 가능

         bool bo = 10 < 3;
         //이런 식으로 값 할당 가능

         //if랑 for while 문은 다 사용 똑같음
         //foreach 문 주의! => 이건 해당 리스트나 배열 안에 있는 값 출력하는 방식
         //반복 변수의 값은 수정 불가
         foreach(int i in im)
         {
             print(i);
         }

         //스위치 구문 자주 활용함 
         switch (im[0])
         {
             case 1:
                 break;
             default:
                 break;
         }
         im[0] = Heal();
        */
        print(m[0]);
        mnc.id = 3;
        print(mnc.id);
    }
    int Heal()
    {
        int a = 999;
        return a;
    }
}
