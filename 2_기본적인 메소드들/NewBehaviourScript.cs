using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
//���Ⱑ �ʱ�ȭ �κ�
    //���� ������Ʈ ���� �� ���ʷ� ����Ǵ� �Լ�
    void Awake()
    {

        print("�ʱ�ȭ");
    }
    //������Ʈ ���� ���� ���ʷ� �����
    void Start()
    {

        print("����");
    }

//���� ������Ʈ Ȱ��ȭ ���� �κ� �갡 start���� ���� ��µ�
    void OnEnable()
    {

        print("�α���");
    }

    //�������� ������Ʈ
    //1 �ʿ� �� ���� ���� => cpu���� ���� ��Ƹ���
    void FixedUpdate()
    {

        print("������ ������Ʈ");
    }

//���� ���� ����
    void Update()
    {

        print("������Ʈ");
    }
    //�ִ� ������ ������Ʈ 
    void LateUpdate()
    {

        print("������ ������Ʈ");
    }

//������Ʈ ��Ȱ��ȭ ���� ����
    void OnDisable()
    {
        print("�α׾ƿ�");
        
    }


    //��ü ����
    //������Ʈ ���� �� �̷��� �� 
    private void OnDestroy()
    {
        print("����");

    }
}
