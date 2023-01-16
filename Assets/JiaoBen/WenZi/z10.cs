using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class z10 : MonoBehaviour
{
    public Text Me;
    public GameObject next;
    void Start()
    {
        StartCoroutine(TypeText(Me, "......", 0.2f));
        Invoke("gonext", 2.5f);
        Invoke("ds", 2f);
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

    void gonext()
    {
        next.SetActive(true);
    }

    void ds()
    {
        gameObject.SetActive(false);
    }

}
