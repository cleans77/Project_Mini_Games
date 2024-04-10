using UnityEditor;
using UnityEngine;

public class Player_Code : MonoBehaviour
{
    float PosX;

    Vector2 MovePosition;
    Rigidbody2D rd;

    //public LayerMask TarGet;
    private void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        InputKey();
        Controller();
    }
    void InputKey()
    {
        PosX = Input.GetAxisRaw("Horizontal");
        if(Input.GetKeyDown(KeyCode.Space))
            Jumping();
    }
    void Controller()
    {
        Moveing();
        Runing();
    }
    void Moveing()
    {
        MovePosition = new Vector2(PosX * PlayerStats.Gm.Speed, rd.velocity.y);
        rd.velocity = MovePosition;
    }
    void Jumping()
    {
        rd.velocity = Vector2.up * PlayerStats.Gm.JumpForce;
    }
    void Runing()
    {
        if (Input.GetKey(PlayerStats.Gm.Run_Key) && PlayerStats.Gm.Stamina > PlayerStats.Gm.MinStamina && PlayerStats.Gm.isRuning == true)
        {
            //스피드가 최대치 보다 낮을 경우 최대치 까지 속도를 올림.
            if (PlayerStats.Gm.Speed < PlayerStats.Gm.MaxSpeed)
                PlayerStats.Gm.Speed += PlayerStats.Gm.Speed * Time.deltaTime;

            PlayerStats.Gm.Stamina -= PlayerStats.Gm.DellStamina * Time.fixedDeltaTime;
            
            //달리기의 스테미너가 최저치 까지 사용될 경우 지친 상태로 변경(isRuing = false;)
            if (PlayerStats.Gm.Stamina <= PlayerStats.Gm.MinStamina)
            {
                PlayerStats.Gm.isRuning = !PlayerStats.Gm.isRuning;
                PlayerStats.Gm.Speed = PlayerStats.Gm.OringerSpeed / 1.8f;
            }
        }
        else if (PlayerStats.Gm.Stamina < PlayerStats.Gm.MaxStamina)
        {
            //isRuning반환
            if (PlayerStats.Gm.isRuning && PlayerStats.Gm.Stamina >= PlayerStats.Gm.MinStamina - 0.5f)
                PlayerStats.Gm.isRuning = true;

            //속도 기본으로 되돌림
            if (PlayerStats.Gm.Speed > PlayerStats.Gm.OringerSpeed && PlayerStats.Gm.isRuning)
                PlayerStats.Gm.Speed -= PlayerStats.Gm.Speed * Time.fixedDeltaTime;

            //스테미나 회복
            if (PlayerStats.Gm.isRuning)
            PlayerStats.Gm.Stamina += 1f * Time.deltaTime;
            else//천천히 회복
            {
                float a = 0;
                a = a + 1f* Time.deltaTime;
                PlayerStats.Gm.Stamina += a;
                if(PlayerStats.Gm.Stamina >= PlayerStats.Gm.MaxStamina - 0.5f)
                {
                    PlayerStats.Gm.isRuning = true;
                }
            }    
        }
    }
}
