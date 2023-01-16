using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class z21 : MonoBehaviour
{
    public Text Me;
    public GameObject next;
    public Animator animator;
    void Start()
    {
        StartCoroutine(TypeText(Me, "什么声音?", 0.15f));
        animator.SetBool("shake", false);
        Invoke("gonext", 8f);
        Invoke("ds", 3f);
        Invoke("ani", 5.5f); //这里需要播放声音
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
