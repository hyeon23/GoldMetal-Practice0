public class Actor
{//public을 입력하지 않을 시 private 작성
    public int id;
    public string name;
    public string title;
    public string weapon;
    public float strength;
    public int level;

    //private 생략은 멤버 함수도 마찬가지
    public string Talk()
    {
        return "대화를 걸었습니다.";
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
