using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class z27 : MonoBehaviour
{
    public Text Me;
    public GameObject next;
    void Start()
    {
        StartCoroutine(TypeText(Me, "��û��ʱ��ȥ�ֻ��ˣ����ڱ���Ҫ�뿪���", 0.15f));
        Invoke("gonext", 5f);
        Invoke("ds",4.5f);
    }

    IEnumerator TypeText(Text me , string str , float speed)
    {
        int i = 0;
        while(i <= str.Length)
        {
            me.text = str.Substring(0,i++);
            yield return new WaitForSeconds(speed);
        }    
    }

    private void gonext()
    {
        next.SetActive(true);
    }

    private void ds()
    {
        gameObject.SetActive(false);
    }
}
