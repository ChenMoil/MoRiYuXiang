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
        StartCoroutine(TypeText(Me, "Ϊʲô�����������ѵ���--", 0.15f)); 
        Invoke("gonext", 7.5f);
        Invoke("ds", 4.5f);
        Invoke("ani", 5f);  //������Ҫ��������
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
