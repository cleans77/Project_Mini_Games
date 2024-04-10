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
            //���ǵ尡 �ִ�ġ ���� ���� ��� �ִ�ġ ���� �ӵ��� �ø�.
            if (PlayerStats.Gm.Speed < PlayerStats.Gm.MaxSpeed)
                PlayerStats.Gm.Speed += PlayerStats.Gm.Speed * Time.deltaTime;

            PlayerStats.Gm.Stamina -= PlayerStats.Gm.DellStamina * Time.fixedDeltaTime;
            
            //�޸����� ���׹̳ʰ� ����ġ ���� ���� ��� ��ģ ���·� ����(isRuing = false;)
            if (PlayerStats.Gm.Stamina <= PlayerStats.Gm.MinStamina)
            {
                PlayerStats.Gm.isRuning = !PlayerStats.Gm.isRuning;
                PlayerStats.Gm.Speed = PlayerStats.Gm.OringerSpeed / 1.8f;
            }
        }
        else if (PlayerStats.Gm.Stamina < PlayerStats.Gm.MaxStamina)
        {
            //isRuning��ȯ
            if (PlayerStats.Gm.isRuning && PlayerStats.Gm.Stamina >= PlayerStats.Gm.MinStamina - 0.5f)
                PlayerStats.Gm.isRuning = true;

            //�ӵ� �⺻���� �ǵ���
            if (PlayerStats.Gm.Speed > PlayerStats.Gm.OringerSpeed && PlayerStats.Gm.isRuning)
                PlayerStats.Gm.Speed -= PlayerStats.Gm.Speed * Time.fixedDeltaTime;

            //���׹̳� ȸ��
            if (PlayerStats.Gm.isRuning)
            PlayerStats.Gm.Stamina += 1f * Time.deltaTime;
            else//õõ�� ȸ��
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
