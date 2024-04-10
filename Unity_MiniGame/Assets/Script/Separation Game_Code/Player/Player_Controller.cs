using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == "Note")
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                Destroy(other.gameObject);
                Debug.Log("±»");
            }
        }
    }
}
