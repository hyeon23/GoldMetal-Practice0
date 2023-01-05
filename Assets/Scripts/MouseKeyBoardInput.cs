using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseKeyBoardInput : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //Ű���� & ���콺 �Է�
        //1. Input: ���� �� �Է��� �������ִ� Ŭ����
        if (Input.anyKeyDown)//Input.anyKeyDown: ������ �Է�(���콺 & Ű����)�� ���� �� Ȱ��ȭ
        {
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");
        }
        if (Input.anyKey)//Input.anyKey
        {
            Debug.Log("�÷��̾ �ƹ� Ű�� ������ �ֽ��ϴ�.");
        }
        //�Ϲ������� Down�� ���� Ű����� ���� Ű������ ���̴� �̷��ϴ�

        //Ű���� �Է�
        //GetKey: Ű���� ��ư �Է��� ������ true
        //Down & Stay & Up ���� ����
        if (Input.GetKeyDown(KeyCode.Return)) // =Enter KeyCode.Enter�� ����.
        {
            Debug.Log("�������� �����߽��ϴ�.");
        }
        if (Input.GetKeyDown(KeyCode.Escape)) // =ESC KeyCode.ESC�� ����.
        {
            Debug.Log("ȯ�漳��");
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("�������� �̵� ��");
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Debug.Log("���������� �̵� ��");
        }

        //���콺 �Է�
        //GetMouseButton
        //Down & Stay & Up���� ����
        //0: ���콺 ���� ��ư
        //1: ���콺 ������ ��ư
        if (Input.GetMouseButtonDown(0))
            Debug.Log("�̻��� �߻�!");
        if (Input.GetMouseButton(0))
            Debug.Log("�̻��� ������ ��");
        if (Input.GetMouseButtonUp(0))
            Debug.Log("���� �̻��� �߻�");

        //�Է¹�� 3
        //Input Manager�� ���� �Է�
        if (Input.GetButtonDown("Jump"))//GetButton�� InputManager�� �̸� ���� ���ڿ����� �ۼ����ش�.
            Debug.Log("����!");
        if (Input.GetButton("Jump"))
            Debug.Log("���� ������ ��...");
        if (Input.GetButtonUp("Jump"))
            Debug.Log("���� ����!!!");
        //Ⱦ�̵�
        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("Ⱦ �̵� ��..." + Input.GetAxis("Horizontal"));//����, ���� �Է��� ������ ���� ũ�⸸ŭ flaot ��ȯ
            //-0.0... ~ -1���� or 0.0 ~ 1����
            //���������� ���� ==> ���ӵ��� ȿ��

            //���ӵ��� �ʿ� ���ٸ�
            Debug.Log("Ⱦ �̵� ��..." + Input.GetAxisRaw("Horizontal"));// 1, -1�� float �� ���
            //2�� Ű ���ÿ� �Է½� 0
        }
        //���̵�
        if (Input.GetButton("Vertical"))
        {
            Debug.Log("�� �̵� ��..." + Input.GetAxis("Vertical"));//����, ���� �Է��� ������ ���� ũ�⸸ŭ flaot ��ȯ
            //���ӵ��� �ʿ� ���ٸ�
            Debug.Log("�� �̵� ��..." + Input.GetAxisRaw("Vertical"));// 1, -1�� float �� ���
            //2�� Ű ���ÿ� �Է½� 0
        }

    }
}
