using PlS;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class BoneMove : MonoBehaviour
{
    public Transform TarGet = null;
    public int Speed = 3;
    private Rigidbody2D rd;
    private void Start()
    {
        TarGet = GameObject.FindWithTag("Player").GetComponent<Transform>();
        rd = GetComponent<Rigidbody2D>();

        if (transform.position.x > TarGet.position.x)
        {
            Speed *= -1;
        }
        else
        {
            Speed *= 1;
        }
    }
    private void Update()
    {
        rd.velocity = new Vector2(Speed, transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision != null)
        {
            if(collision.gameObject.tag == "Player")
            {
                Undertale_PlayerStats.Hp -= 10;
                Destroy(this);
            }
            if(collision.gameObject.tag == "Wall")
            {
                Destroy(this);
            }
        }
    }
}
