using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class z11 : MonoBehaviour
{
    public Text Me;
    public GameObject next;
    void Start()
    {
        StartCoroutine(TypeText(Me, "...���ǣ����ǡ�", 0.2f));
        Invoke("gonext", 3.5f);
        Invoke("ds", 3f);
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
