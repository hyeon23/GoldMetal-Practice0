using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transportation : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);


    void Update()
    {
        //1. MoveTowards: ����̵� �Լ�
        //�Ű����� (Vector3 ���� ��ġ, Vector3 ��ǥ ��ġ, �ӵ�)//�ӵ��� Ŭ ���� ������
        transform.position = Vector3.MoveTowards(transform.position, target, 1f * Time.deltaTime);

        //2. SmoothDamp: �ε巯�� ���� �̵�
        Vector3 velo = Vector3.zero;
        //SmoothDamp ���� velo�� ���� zero�� �����Ѵ�. �ƴ� �� ��ǥ ������ �ǹ̸� ����ϰ� ��
        transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f * Time.deltaTime);//������ ���� ���� ���� ���� ������
        //ref: �Ű�x �ʹ� ����� �̷�

        //3. Lerp: ���� ����, SmoothDamp���� ������ ��� ��
        transform.position = Vector3.Lerp(transform.position, target, 0.1f * Time.deltaTime);//������ MoveToward�� ����
                                                                          //1�� max��, 0.5�� �߰�, 0.0000...1�� ���� ��

        //4. Slerp(���� ���� ����): �������� �׸��� �̵�
        transform.position = Vector3.Slerp(transform.position, target, 0.1f * Time.deltaTime);
    }
}
