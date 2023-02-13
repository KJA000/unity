using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        //transform : 디폴트로 설정되어 있음 기본적으로 초기화된 변수가 있음

        //Translate : 내부 벡터값을 얼마만큼 이동하는지 설정 가능한 메소드 x,y,z축 설정 가능
        //3차원의 경우 Vector3, 2차원은 Vector2
        int num = 4;
        Vector3 vec = new Vector3(0, 0, 0);
        transform.Translate(vec);


    }
    void Update()
    {
        /*
       // 계속 움직임 카메라에도 넣고 오브젝트에도 넣으면 같이 움직일 수 있음
        Vector3 vec = new Vector3(0.1f, 0, 0);
        transform.Translate(vec);
        */

        //키보드 상하좌우키로 오브젝트 움직이기 가능
        //Raw로 하면 더 빨리 감 중간값을 무시하기 때문에 
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.Translate(vec);
    }

}
