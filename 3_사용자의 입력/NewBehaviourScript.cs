using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�������� ������Ʈ ���� -> �Է� �����ڸ� ���� �������� ������ ����
public class NewBehaviourScript : MonoBehaviour
{
    void Update()
    {
        //bool Ÿ�� Ŭ������ ����Ƽ���� �⺻������ ���� MonoBehaviour �� ����
        if (Input.anyKeyDown) print("������");
       //bool Ÿ�� �� ������ ������ �� ��ȯ�ϴ� ��
        //print(Input.anyKey);
        ///////////
        //Down : ������ ��/ Stay : �� ������ ���� ��/ UP : ������ ���� ��

        //GetKey�� anykey ó�� ���� ���� �νĵ� ��� ������ �ִ� ���·� �νĵ�
        if (Input.GetKey(KeyCode.LeftArrow)) print("�������� �̵� ��");

        //�̰� ����Ű ��Ī�ϴ� ����
        if (Input.GetKeyDown(KeyCode.Return)) print("������ ����");

        //�̰� esc ��Ī�ϴ� ����
        if (Input.GetKeyDown(KeyCode.Escape)) print("Ż��");


        //��� �� ���� �νĵ� 
        if (Input.GetKeyUp(KeyCode.RightArrow)) print("���������� �̵�");

        //���콺 �ν��� GetMouse �� ������ ��Ŭ���� �Ű����� 0�̰� ��Ŭ���� 1
        if (Input.GetMouseButtonDown(0)) print("���콺 ��Ŭ��");

        if (Input.GetMouseButton(0)) print("���콺 �� Ŭ��");

        if (Input.GetMouseButtonUp(1)) print("���콺 ��Ŭ��");

        //�������� ������Ʈ ���� -> �Է� �����ڸ� ���� �������� ������ ����
        //������ �̸� ���ڿ��� �Ű������� �־��ָ� �۵��ϴ� �����
        if (Input.GetButtonDown("Jump")) print("����");

        //���� ���� ��ư �Է� �� float Ⱦ �� ��ȯ(���ӵ�)
        //vertical�� ����
        if (Input.GetButtonDown("Horizontal")) print("Ⱦ �̵�"+ Input.GetAxis("Horizontal"));

        //AxisRaw�� �ϸ� ���� �����ʸ� ��Ÿ�� �� 1 �� -1��
        if (Input.GetButtonDown("Horizontal")) print("Ⱦ �̵�" + Input.GetAxisRaw("Horizontal"));


    }
}
