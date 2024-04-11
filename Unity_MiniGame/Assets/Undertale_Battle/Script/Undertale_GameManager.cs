using UnityEngine;
using PlS;
using System.Collections;
using Unity.Collections.LowLevel.Unsafe;

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

    int Index = 0;                          //공격 패턴 순번
    int AttatkCount = 0;                //공격 횟수
    private void Update()
    {
        if (Undertale_PlayerStats.InPlay)
            CheackUpdateAttake();
        else NotAttake();
    }
    void CheackUpdateAttake()//공-격 순번 체크
    {
            switch (Index)
            {
                case 0:
                Attack_pattern_1();
                Debug.Log("1");
                    break;
                case 1:
                Debug.Log("2");
                break;
                case 2:
                Debug.Log("3");
                break;
                case 3:
                Debug.Log("4");
                break;
                case 4:
                Debug.Log("5");
                break;
                case 5:
                Debug.Log("6");
                break;
                case 6:
                Debug.Log("7");
                break;
                case 7:
                Debug.Log("8");
                break;
                case 8:
                Debug.Log("9");
                break;
                case 9:
                Debug.Log("10");
                break;
                case 10:
                Debug.Log("11");
                break;
            }
    }
    void NotAttake()        //공-격 정지 체크
    {
        
    }

    void Attack_pattern_1()
    {
        AttatkCount = 10;
        StartCoroutine("Attake_Bone");
        if(AttatkCount > 0)
        {
            Undertale_PlayerStats.InPlay = false;
        }
    }

    IEnumerator Attake_Bone()
    {
        while(AttatkCount >= 0)
        {
            yield return new WaitForSeconds(0.5f);
            Instantiate(Bone, Spawn_Position[Random.Range(0, 5)]);
            AttatkCount --;
        }
    }
}