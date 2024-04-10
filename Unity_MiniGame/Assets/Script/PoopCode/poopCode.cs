using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class poopCode : MonoBehaviour
{
    public Transform[] TarGetPosition;
    public GameObject Amount;

    public 난이도 ㄴㅇㄷ;

    public float Count;
    public float DellTime;
    private void Start()
    {
        if(ㄴㅇㄷ == 난이도.이지)
        {
            Count = 30;
            DellTime = 1f;
        }
        else if(ㄴㅇㄷ == 난이도.보통)
        {
            Count = 50;
            DellTime = 0.8f;
        }
        else if(ㄴㅇㄷ == 난이도.하드)
        {
            Count = 70;
            DellTime = 0.6f;
        }
        else if(ㄴㅇㄷ == 난이도.더_하드)
        {
            Count = 100;
            DellTime = 0.6f;
        }
        else if(ㄴㅇㄷ == 난이도.더_더_하드)
        {
            Count = 150;
            DellTime = 0.5f;
        }
        else if(ㄴㅇㄷ == 난이도.존나_하드)
        {
            Count = 220;
            DellTime = 0.4f;
        }
        else if(ㄴㅇㄷ == 난이도.종말)
        {
            Count = 300;
            DellTime = 0.3f;
        }
        else if(ㄴㅇㄷ == 난이도.익스페이션)
        {
            Count = 1000;
            DellTime = 0.2f;
        }
        StartCoroutine("Spawon");
    }
    IEnumerator Spawon()
    { 
        while (Count > 0) { 
            yield return new WaitForSeconds(DellTime);
            SpawPop();
            Count--;
        }
    }
    void SpawPop()
    {
        Vector3 Pos = Vector3.Lerp(TarGetPosition[0].position, TarGetPosition[1].position, Random.value);
        if(ㄴㅇㄷ == 난이도.익스페이션)
        {
            Instantiate(Amount, Pos, Quaternion.identity);
            Pos = Vector3.Lerp(TarGetPosition[0].position, TarGetPosition[1].position, Random.value);
            Instantiate(Amount, Pos, Quaternion.identity);
            Pos = Vector3.Lerp(TarGetPosition[0].position, TarGetPosition[1].position, Random.value);
            Instantiate(Amount, Pos, Quaternion.identity);
            Pos = Vector3.Lerp(TarGetPosition[0].position, TarGetPosition[1].position, Random.value);
            Instantiate(Amount, Pos, Quaternion.identity);
        }
        else
        Instantiate(Amount, Pos, Quaternion.identity);
    }
    private void Update()
    {
        if (Count <= 0)
        {
            Invoke("EndGame", 3f);
        }
    }
    void EndGame()
    {
        SceneManager.LoadScene("MainWindow");
    }
}
