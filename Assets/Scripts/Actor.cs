public class Actor
{//public�� �Է����� ���� �� private �ۼ�
    public int id;
    public string name;
    public string title;
    public string weapon;
    public float strength;
    public int level;

    //private ������ ��� �Լ��� ��������
    public string Talk()
    {
        return "��ȭ�� �ɾ����ϴ�.";
    }
    public string HasWeapon()
    {
        return weapon;
    }
    public void LevelUp()
    {
        level += 1;
    }

        
}
