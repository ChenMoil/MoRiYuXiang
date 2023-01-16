using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class z20 : MonoBehaviour
{
    public Text Me;
    public GameObject next;
    public Animator animator;
    void Start()
    {
        StartCoroutine(TypeText(Me, "为什么会变成这样？难道是--", 0.15f)); 
        Invoke("gonext", 7.5f);
        Invoke("ds", 4.5f);
        Invoke("ani", 5f);  //这里需要播放声音
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
    private void ani()
    {
        animator.SetBool("shake", true);
        soundmanger.hou();
    }
}
