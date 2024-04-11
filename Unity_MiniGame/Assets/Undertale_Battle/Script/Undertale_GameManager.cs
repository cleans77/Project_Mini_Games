using UnityEngine;
using PlS;
using System.Collections;
using Unity.Collections.LowLevel.Unsafe;

public enum Attack_action
{
    baseAttake,
    SkillAttake,
}
//�� ���� �޴���
public class Undertale_GameManager : MonoBehaviour
{
    Attack_action Act;                  //���� ��� ���� �ڵ�
    public Transform[] Spawn_Position = null;  //���� ���� ��ġ
    [SerializeField] private GameObject Bone = null;        //�⺻ ���� ������
    [SerializeField] private GameObject GarstBlade = null;  //������ ���̵� ������

    [SerializeField] private Transform Ground_Point = null;    //�� ��ġ��
    [SerializeField] private Transform Ceiling_Point = null;   //õ�� ��ġ��

    int Index = 0;                          //���� ���� ����
    int AttatkCount = 0;                //���� Ƚ��
    private void Update()
    {
        if (Undertale_PlayerStats.InPlay)
            CheackUpdateAttake();
        else NotAttake();
    }
    void CheackUpdateAttake()//��-�� ���� üũ
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
    void NotAttake()        //��-�� ���� üũ
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