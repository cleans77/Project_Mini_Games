using UnityEngine;

//�÷��̾� ��Ʈ�ѷ�
public class Undertale_PlayerCode : MonoBehaviour
{
    [SerializeField]
    float Speed = 3;
    [SerializeField]
    float JumpForce = 5;

    int JumpCount = 1;

    float PosX;
    float PosY;


    bool isLongJump;
    bool isGround = true;

    public LayerMask tarGet;

    Vector2 Ground;

    Rigidbody2D rd;
    CircleCollider2D circleCollider;
    [SerializeField]private PlayerSituation PS;             //PLayer Situation Enum /�÷��̾� ���� ������
    void Start()
    {
        circleCollider = GetComponent<CircleCollider2D>();
        rd = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if(PS == PlayerSituation.Baisc)
        {
            rd.gravityScale = 0;
            NotRD_Player_Controller();
        }
        else if(PS == PlayerSituation.�Ķ���Ʈ)
        {
            rd.gravityScale = 1;
            ONRD_Move_Controller();
        }
        else if(PS == PlayerSituation.�����Ʈ)
        {
            rd.gravityScale = 0;
        }
        InputKey();
        test();
    }
    void test()
    {
        //���� if�� �� ���ư����� Ȯ�ο�
        if(Input.GetKey(KeyCode.Alpha1))
        {
            PS = PlayerSituation.Baisc;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            PS = PlayerSituation.�Ķ���Ʈ;
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            PS = PlayerSituation.�����Ʈ   ;
        }
    }
    void InputKey()
    {
        PosX = Input.GetAxisRaw("Horizontal");
        PosY = Input.GetAxisRaw("Vertical");
    }
    //��Ʈ�� �Ķ����� ���
    void NotRD_Player_Controller()
    {
        rd.velocity = new Vector2(PosX * Speed,PosY * Speed);
    }
    void ONRD_Move_Controller()
    {
        Move();
        Jumping();
    }
    void Move()
    {
        rd.velocity = new Vector2(PosX * Speed, rd.velocity.y);
    }
    void Jumping()
    {
        Bounds bound = circleCollider.bounds;
        Ground = new Vector2(bound.center.x, bound.min.y);
        isGround = Physics2D.OverlapCircle(Ground, 0.1f, tarGet);

        if(Input.GetKey(KeyCode.Space))
        {
            rd.gravityScale = 1f;
        }
        else
        {
            rd.gravityScale = 2.5f;
        }
        if (isGround == true && rd.velocity.y <= 0)
        {
            JumpCount = 1;
        }
        if(Input.GetKeyDown(KeyCode.Space) && JumpCount > 0)
        {
            rd.velocity = Vector2.up * JumpForce;
            JumpCount--;
        }
    }
}
