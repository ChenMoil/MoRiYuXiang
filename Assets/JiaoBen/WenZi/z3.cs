using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class z3 : MonoBehaviour
{
    public Text Me;
    public GameObject next;
    public Animator ami;
    void Start()
    {
        StartCoroutine(TypeText(Me, "你在逃避！逃避吾主所恩赐予你的命运！", 0.1f));
        Invoke("gonext", 2.5f);
        Invoke("ds", 4.5f);
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
        ami.SetBool("qiehuan",true);
    }

    private void ds()
    {
        gameObject.SetActive(false);

    }

}
