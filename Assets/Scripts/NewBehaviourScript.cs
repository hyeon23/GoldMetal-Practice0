using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour//public class
    //10. ���
    //��찡 ����ϼ��� �������ϼ��� �Ǹ��ϼ���
    //����� Ŭ������ ������ �� �ٸ� Ŭ������ ���� �� �ִ�.
    //MonoBehaviour: ����Ƽ ���� ������Ʈ Ŭ����
{
    //��������
    string title = "������";
    string playerName = "���˻�";
    int level = 5;
    float strength = 15.5f;
    int exp = 1500;
    int health = 30;
    int mana = 25;
    bool isFullLevel = false;

    void Start()
    {
        //0. ����
        //Debug.Log("Hello Unity!");
        //===========================================================================
        //1. ���� = �������� + ��������
        //int, float[f ��� �ʼ�], string, bool ���
        //���� + �ʱ�ȭ�� ����
        //���� >> �ʱ�ȭ >> ȣ�� ������ �۵�
        //===========================================================================
        //Debug.Log("����� �̸���?");
        //Debug.Log(playerName);
        //Debug.Log("����� ������?");
        //Debug.Log(level);
        //Debug.Log("����� ����?");
        //Debug.Log(strength);
        //Debug.Log("���� �����ΰ�?");
        //Debug.Log(isFullLevel);
        //===========================================================================
        ////2. �迭 ��� ���
        ////�迭: �׷��� ����
        string[] monsters = { "������", "�縷��", "�Ǹ�" };
        int[] monstersLevel = new int[3];
        monstersLevel[0] = 1;
        monstersLevel[1] = 10;
        monstersLevel[2] = 99;
        //Debug.Log("�ʿ� �����ϴ� ����");
        //Debug.Log(monsters[0]);
        //Debug.Log(monsters[1]);
        //Debug.Log(monsters[2]);
        //Debug.Log("�ʿ� �����ϴ� ���� ����");
        //Debug.Log(monstersLevel[0]);
        //Debug.Log(monstersLevel[1]);
        //Debug.Log(monstersLevel[2]);
        //===========================================================================
        //3. ����Ʈ ����
        //����Ʈ: ����� �߰��� ������ �׷��� ����
        //�迭���� �ٸ��� ���� ����
        List<string> items = new List<string>();
        items.Add("������30");
        items.Add("������60");
        Debug.Log(items[0]);
        Debug.Log(items[1]);

        items.RemoveAt(1);//����Ʈ�� �ش� index ���빰�� �����ϰ� ������ ����ִ� ��
        Debug.Log(items[0]);
        //===========================================================================
        //4. ������
        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;
        int nextExp = 300 - (exp % 300);

        Debug.Log("����� �̸���?");
        Debug.Log(title + " " + playerName);
        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        Debug.Log("���� �����Դϱ�?" + isFullLevel);
        bool isEndTutorial = level >= 10;
        Debug.Log("Ʃ�丮���� ���� ����Դϱ�?" + isEndTutorial);

        bool isBadCondition = health <= 50 && mana <= 20; // &&: and, ||: or, ~: not
        Debug.Log("����� ���°� ���޴ϱ�?" + isBadCondition);

        string condition = isBadCondition ? "����" : "����";//? �� : ���� �� ����
        //===========================================================================
        //5. Ű����: ���α׷��� �� �����ϴ� Ư���� �ǹ̰� ����� ��� ex int, float, string, bool, new, List ��
        //-���� �̸� or ������ ��� �Ұ�
        //===========================================================================
        //6. ���ǹ�: if / else if / for
        if (condition == "����")
        {
            Debug.Log("�÷��̾��� ���°� ���ڴ� �������� ����ϼ���");
        }
        else
        {
            Debug.Log("�÷��̾��� ���°� �����ϴ�.");
        }
        if(isBadCondition && items[0] == "������30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("��������30�� ����߽��ϴ�.");
        }
        else if(isBadCondition && items[0] == "��������30")
        {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("��������30�� ����߽��ϴ�.");
        }
        switch (monsters[0])
        {
            case "������":
            case "�縷��":
                Debug.Log("���� ���Ͱ� ����!");
                break;
            case "�Ǹ�":
                Debug.Log("���� ���Ͱ� ����!");
                break;
            case "��":
                Debug.Log("���� ���Ͱ� ����!");
                break;
            default://��� case���� �������� ������ �� ���������� ����Ǵ� ����
                Debug.Log("�� �� ���� ũ��");
                break;
        }
        //===========================================================================
        //7. �ݺ��� (while / for)
        while (health > 0)//�� ��Ʈ�� Ȱ��
        {
            health--;
            if (health > 0)
                Debug.Log("�� �������� �Ծ����ϴ�. " + health);
            else
                Debug.Log("����ϼ̽��ϴ�.");
            if(health == 10)
            {
                Debug.Log("�ص����� ����մϴ�.");
                break;
            }
        }
        for(int count = 0; count < 10; count++)
        {
            health++;
            Debug.Log("�ش�� ġ�� ��..." + health);
        }
        //for���� �ִ� ������ �׷��� ������ Ȱ�뿡 �ִ�.

        for(int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("�� ������ ���� : " + monsters[index]);
        }

        foreach (string monster in monsters)//for���� ��ȭ�� ����
        {
            Debug.Log("�� ������ ���� : " + monster);
        }
        //8. �Լ�(method)
        health = Healing(health);
        Heal();
        for (int i = 0; i < monsters.Length; i++)
        {
            Debug.Log("����" + monsters[i] + "����" + Battle(monstersLevel[i]));
        }
        //===========================================================================

        //9. Ŭ����
        //�ϳ��� �繰(=������Ʈ)�� �����ϴ� ����
        //10. ��ӵ� �Բ� ���
        Actor a = new Actor();
        Player player = new Player();//Ŭ������ �ϳ��� ������ ���� ==> �ν��Ͻ�ȭ
        player.id = 0;
        player.name = "������";
        player.title = "������";
        player.strength = 2.4f;
        player.weapon = "���� ������";
        Debug.Log(player.Talk());
        Debug.Log(player.name + "�� ������ " + player.level + "�Դϴ�.");


    }
    //8. �Լ�(method)
    int Healing(int currentHealth)
    {
        currentHealth += 10;
        Debug.Log("���� �޾ҽ��ϴ�. " + currentHealth);
        return currentHealth;
    }

    void Heal()//��ȯ �����Ͱ� ���� Ÿ���� �޼ҵ�
    {
        health += 10;
        Debug.Log("���� �޾ҽ��ϴ�. " + health);
        //health�� �� ����. Start�ȿ��� ���ǵ� ���̱� �����̴�. 
        //health�� Start �Լ��� ���� �����̱� �����̴�. => �ٸ� �Լ����� �������� ���� �Ұ���
        //��� �Լ��� �����Ӱ� ������ ����� �� �ְ� �ϱ� ���� ��� => �������� ����: ������ ���� ���ʿ� ����
    }
    string Battle(int monsterLevel)
    {
        string result;
        if(level >= monsterLevel)
        {
            result = "win";
        }
        else
        {
            result = "lose";
        }
        return result;
    }
    //===========================================================================
}
