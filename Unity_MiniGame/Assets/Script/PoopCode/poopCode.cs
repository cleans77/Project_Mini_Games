using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class poopCode : MonoBehaviour
{
    public Transform[] TarGetPosition;
    public GameObject Amount;

    public ���̵� ������;

    public float Count;
    public float DellTime;
    private void Start()
    {
        if(������ == ���̵�.����)
        {
            Count = 30;
            DellTime = 1f;
        }
        else if(������ == ���̵�.����)
        {
            Count = 50;
            DellTime = 0.8f;
        }
        else if(������ == ���̵�.�ϵ�)
        {
            Count = 70;
            DellTime = 0.6f;
        }
        else if(������ == ���̵�.��_�ϵ�)
        {
            Count = 100;
            DellTime = 0.6f;
        }
        else if(������ == ���̵�.��_��_�ϵ�)
        {
            Count = 150;
            DellTime = 0.5f;
        }
        else if(������ == ���̵�.����_�ϵ�)
        {
            Count = 220;
            DellTime = 0.4f;
        }
        else if(������ == ���̵�.����)
        {
            Count = 300;
            DellTime = 0.3f;
        }
        else if(������ == ���̵�.�ͽ����̼�)
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
        if(������ == ���̵�.�ͽ����̼�)
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
