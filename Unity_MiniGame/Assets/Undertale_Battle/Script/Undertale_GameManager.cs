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

    Vector2[] NotePos;                  //��� �ȳ� ��
}