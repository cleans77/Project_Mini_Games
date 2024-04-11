public enum PlayerSituation
{
    Baisc,          //아무런 제약 없는 상태
    파랑하트,       //중력값 받는 상태
    노랑하트,       //고정 상태
}
namespace PlS
{
    //플레이어 스텟 관리 스크립트&클래스
    public static class Undertale_PlayerStats
    {
        public static int Lv = 19;
        public static int Hp = 99;
        public static int Damage;
        public static bool InPlay = true;
    }
}

