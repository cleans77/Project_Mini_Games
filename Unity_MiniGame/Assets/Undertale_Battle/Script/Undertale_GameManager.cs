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
    [SerializeField] private GameObject Bone = null;        //기본 공격 프리팹
    [SerializeField] private GameObject GarstBlade = null;  //가스터 블레이드 프리팹

    [SerializeField] private Transform Ground_Point = null;    //땅 위치값
    [SerializeField] private Transform Ceiling_Point = null;   //천장 위치값

    [SerializeField]
    Vector2[] NotePos;                  //기억 안남 ㅋ

    public void Transofqokdfodfbopfjengwds(string adada)
    {

    }
}