using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        //transform : ����Ʈ�� �����Ǿ� ���� �⺻������ �ʱ�ȭ�� ������ ����

        //Translate : ���� ���Ͱ��� �󸶸�ŭ �̵��ϴ��� ���� ������ �޼ҵ� x,y,z�� ���� ����
        //3������ ��� Vector3, 2������ Vector2
        int num = 4;
        Vector3 vec = new Vector3(0, 0, 0);
        transform.Translate(vec);


    }
    void Update()
    {
        /*
       // ��� ������ ī�޶󿡵� �ְ� ������Ʈ���� ������ ���� ������ �� ����
        Vector3 vec = new Vector3(0.1f, 0, 0);
        transform.Translate(vec);
        */

        //Ű���� �����¿�Ű�� ������Ʈ �����̱� ����
        //Raw�� �ϸ� �� ���� �� �߰����� �����ϱ� ������ 
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.Translate(vec);
    }

}
