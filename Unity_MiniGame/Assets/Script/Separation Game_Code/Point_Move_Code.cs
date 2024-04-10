using UnityEngine;
public class Point_Move_Code : MonoBehaviour
{
    public Transform TarGet;
    Rigidbody2D rd;
    public float Speed = 300f;
    private void Update()
    {
        rd.velocity = new Vector2(Speed, transform.position.y);
    }
    private void Start()
    {
        TarGet = GameObject.FindWithTag("Potiton").GetComponent<Transform>();
        rd = GetComponent<Rigidbody2D>();
        if(transform.position.x > TarGet.position.x)
        {
            Speed *= -1f;
        }
        else
        {
            Speed *= 1f; 
        }
    }

}
