using UnityEngine;

public enum PlayerSituation
{
    Baisc,          //아무런 제약 없는 상태
    파랑하트,       //중력값 받는 상태
    노랑하트,       //고정 상태
}
//플레이어 스텟 관리 스크립트&클래스
public class Undertale_PlayerStats : MonoBehaviour
{
    public int Lv = 19;
    public int Hp = 99;
    public int Damage;
}
