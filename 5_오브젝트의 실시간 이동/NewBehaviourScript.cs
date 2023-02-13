using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Vector3 target = new Vector3(-11.52f,-1.14f, -10.63007f);
    void Update()
    {
        //MoveTowards �� �̵���Ű�� ***���� ��ġ, Ÿ��, �̼� �ð�
        transform.position = Vector3.MoveTowards(transform.position,target,1f);

        //�ӵ����� ����
        Vector3 vec0 = Vector3.up*50;
        //0���� ������ ��
        Vector3 vec1 = Vector3.zero;

        //SmoothDamp : �ε巯�� ���� �̵�
        //*** ���� ��ġ, Ÿ��, ���� �ӵ�, �ӵ�
        //�ǽð����� �ٲ�� �� �����ϴ� ���� ����
        transform.position = Vector3.SmoothDamp(transform.position, target,ref vec1, 0.1f);

        //���� ����. SmooothDamp�� �ݴ�� �ӵ����� �۰� �ָ� ������ 
        transform.position = Vector3.Lerp(transform.position, target, 0.1f);

        //���� ���� ����. ������ �׸��鼭 �̵��ϴ� ���
        transform.position = Vector3.Slerp(transform.position, target, 0.1f);

    //��ŸŸ�� : 1�����ӿ� ���� �ð�. ��ǻ�� �� ���ɿ� �°� �����ϱ� ���� Ȯ���ϴ� ��
        //��ŸŸ�� translate ǥ�� ��
        transform.Translate(vec1 * Time.deltaTime);

        //��ŸŸ�� Lerp ǥ�� �� (�ð� ���� ���ϴ� ���)
        Vector3.Lerp(vec0, vec1, 1.5f * Time.deltaTime);

    }
}
