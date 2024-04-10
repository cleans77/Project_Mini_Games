using UnityEngine;

public class PlayerCode : MonoBehaviour
{
    //똥피하기 플레이어 움직임.
    float PosX;

    Rigidbody2D rd;
    private void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        InputKey();
        Moveing();
    }
    void InputKey()
    {
        PosX = Input.GetAxisRaw("Horizontal");
    }
    void Moveing()
    {
        rd.velocity = new Vector2(PosX * PlayerStats.Gm.Speed, rd.velocity.y);
    }
}
