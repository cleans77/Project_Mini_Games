using System.Linq.Expressions;
using UnityEngine;

public enum ���̵�
{
    ����,
    ����,
    �ϵ�,
    ��_�ϵ�,
    ��_��_�ϵ�,
    ����_�ϵ�,
    ����,
    �ͽ����̼�
}
public class PlayerStats : MonoBehaviour
{
    public static PlayerStats Gm;
    [Header("Stats")]
    public float Speed = 5, JumpForce = 8,Stamina = 10;
    public float MaxSpeed,MaxStamina;
    public float MinSpeed,MinStamina;
    public float OringerSpeed;
    public int DellStamina = 1;         //��� �ӵ�.
    [Header("��&�� Ȯ��")]
    public bool isRuning = true;
    [Header("KeyCode")]
    public KeyCode Jump_Key = KeyCode.Space;
    public KeyCode Run_Key = KeyCode.LeftShift;
    private void Awake()
    {
        if(Gm != null)
        {
            DestroyImmediate(this.gameObject);
        }
        Gm = this;    
        DontDestroyOnLoad(this.gameObject);
    }
    private void Start()
    {
        OringerSpeed = Speed;
        MaxSpeed = Speed * 1.5f;MaxStamina = Stamina;
        MinSpeed = Speed / 2f -1;MinStamina = 0;
    }
    private void Update()
    {

    }
}
