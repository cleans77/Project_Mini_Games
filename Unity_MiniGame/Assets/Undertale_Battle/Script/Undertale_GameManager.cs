using UnityEngine;

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

    [SerializeField]
    Vector2[] NotePos;                  //��� �ȳ� ��

    public void Transofqokdfodfbopfjengwds(string adada)
    {

    }
}