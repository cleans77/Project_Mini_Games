using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
//리듬 게임 맵 메니저
public class MapManager : MonoBehaviour
{
    public Transform[] Spawnpoint;
    public GameObject[] Point;
    public int Count = 50;

    public float bpm = 0;
    void Start()
    {
        bpm /= 20f;
        StartCoroutine("도트");
    }
    private void Update()
    {/*
        currtTime += Time.deltaTime;
        if(currtTime >= 60d / bpm)
        {
            currtTime = 60f / bpm;
        }*/
    }
    IEnumerator 도트()
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
