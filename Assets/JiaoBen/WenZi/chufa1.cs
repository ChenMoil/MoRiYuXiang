using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chufa1 : MonoBehaviour
{
    public GameObject shuxing2;
    public GameObject shuxing3;
    public GameObject next;
    void Start()
    {
        Invoke("s2", 0.1f); //������Ҫ��������
        Invoke("s3", 3f); //�л�ͼƬ
        Invoke("gonext", 4f); //������Ļ
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void s2()
    {
        shuxing2.SetActive(false);
    }
    private void s3()
    {
        shuxing3.SetActive(true);
    }
    private void gonext()
    {
        next.SetActive(true);
    }
}
