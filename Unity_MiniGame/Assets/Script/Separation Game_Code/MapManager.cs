using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
//���� ���� �� �޴���
public class MapManager : MonoBehaviour
{
    public Transform[] Spawnpoint;
    public GameObject[] Point;
    public int Count = 50;

    public float bpm = 0;
    void Start()
    {
        bpm /= 20f;
        StartCoroutine("��Ʈ");
    }
    private void Update()
    {/*
        currtTime += Time.deltaTime;
        if(currtTime >= 60d / bpm)
        {
            currtTime = 60f / bpm;
        }*/
    }
    IEnumerator ��Ʈ()
    {
        while (Count > 0)
        {
            yield return new WaitForSeconds(bpm);
            int a;
            a = Random.Range(0, Spawnpoint.Length);
            Debug.Log(a);
            
            if(a == 0)
            {
                Instantiate(Point[0], Spawnpoint[a]);
                Count--;
            }
            else
            {
                Instantiate(Point[0], Spawnpoint[a]);
                Count--;
            }
        }   
    }
}
