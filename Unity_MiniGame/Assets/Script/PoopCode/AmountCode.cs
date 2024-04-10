using UnityEngine;

public class AmountCode : MonoBehaviour
{
    public int Damage = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("DAD");

        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("dd");
                //PlayerStats.Gm.Hp -= Damage;
        }
        else if(collision.gameObject.tag == "Ground")
        {
            Destroy(this.gameObject);
        }
    }
}
