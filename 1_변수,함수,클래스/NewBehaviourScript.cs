using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public
      //���⿡ �����ϴ� ��� �� ���� ������ 

      string[] m = { "a", "b", "c" };
    //�迭 ����
    /*
    int[] a = new int[3];
    //�迭 �����Ҵ�

    List<int> im = new List<int>(2);
    //����Ʈ �ڷ���
    List<string> jm = new List<string>();
    */
    mynewclass mnc = new mynewclass();
    void Start()
    {
        /* 
         im.Add(4);
         im.Add(5);
         //����Ʈ �ڷ����� �̷� ������ ������ �߰��� 
         //�迭�� �� ��� ���� �� �������� ��� 0 ����'
         for(int i=0;i<im.Count;i++)
         {
             print("���� im[i]���̴�");
             print(im[i]);
             print("���� i���̴�");
             print(i);
         }
         im[1] = 3;
         //�ٵ� �̷� ������ �̹� add�� ��쿡�� �迭ó�� �ε��� ����ؼ� �� �Ҵ� ����

         im.RemoveAt(1);
         //������ ���� ���� �� ��� �ε��� ���� �߻�

         print("���� " + "�ٺ���");
         //�ֿܼ� ���� ����� ��� + ��ȣ ����ؼ� ���� �� ��� ����

         bool bo = 10 < 3;
         //�̷� ������ �� �Ҵ� ����

         //if�� for while ���� �� ��� �Ȱ���
         //foreach �� ����! => �̰� �ش� ����Ʈ�� �迭 �ȿ� �ִ� �� ����ϴ� ���
         //�ݺ� ������ ���� ���� �Ұ�
         foreach(int i in im)
         {
             print(i);
         }

         //����ġ ���� ���� Ȱ���� 
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
