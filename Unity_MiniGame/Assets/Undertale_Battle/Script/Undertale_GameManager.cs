using UnityEngine;

public enum Attack_action
{
    baseAttake,
    SkillAttake,
}
//적 전투 메니저
public class Undertale_GameManager : MonoBehaviour
{
    Attack_action Act;                  //공격 방식 선정 코드
    public Transform[] Spawn_Position = null;  //공격 스폰 위치

    Vector2[] NotePos;                  //기억 안남 ㅋ
}