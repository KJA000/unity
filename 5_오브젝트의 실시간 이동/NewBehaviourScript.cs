using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Vector3 target = new Vector3(-11.52f,-1.14f, -10.63007f);
    void Update()
    {
        //MoveTowards 로 이동시키기 ***현재 위치, 타겟, 이속 시간
        transform.position = Vector3.MoveTowards(transform.position,target,1f);

        //속도설정 가능
        Vector3 vec0 = Vector3.up*50;
        //0으로 설정한 것
        Vector3 vec1 = Vector3.zero;

        //SmoothDamp : 부드러운 감속 이동
        //*** 현재 위치, 타겟, 참조 속도, 속도
        //실시간으로 바뀌는 값 적용하는 것이 참조
        transform.position = Vector3.SmoothDamp(transform.position, target,ref vec1, 0.1f);

        //선형 보간. SmooothDamp와 반대로 속도값을 작게 주면 느려짐 
        transform.position = Vector3.Lerp(transform.position, target, 0.1f);

        //구면 선형 보간. 포물선 그리면서 이동하는 방식
        transform.position = Vector3.Slerp(transform.position, target, 0.1f);

    //델타타임 : 1프레임에 사용된 시간. 컴퓨터 각 성능에 맞게 조절하기 위해 확인하는 값
        //델타타임 translate 표현 시
        transform.Translate(vec1 * Time.deltaTime);

        //델타타임 Lerp 표현 시 (시간 값에 곱하는 방식)
        Vector3.Lerp(vec0, vec1, 1.5f * Time.deltaTime);

    }
}
