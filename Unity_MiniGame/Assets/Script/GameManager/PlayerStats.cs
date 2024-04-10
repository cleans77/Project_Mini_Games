using System.Linq.Expressions;
using UnityEngine;

public enum 난이도
{
    이지,
    보통,
    하드,
    더_하드,
    더_더_하드,
    존나_하드,
    종말,
    익스페이션
}
public class PlayerStats : MonoBehaviour
{
    public static PlayerStats Gm;
    [Header("Stats")]
    public float Speed = 5, JumpForce = 8,Stamina = 10;
    public float MaxSpeed,MaxStamina;
    public float MinSpeed,MinStamina;
    public float OringerSpeed;
    public int DellStamina = 1;         //닳는 속도.
    [Header("참&반 확인")]
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
