using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class z28 : MonoBehaviour
{
    public Text Me;
    public GameObject next;
    public GameObject pic3;
    void Start()
    {
        StartCoroutine(TypeText(Me, "那个洞应该足够让我出去了", 0.15f));
        Invoke("gonext", 5f);
        Invoke("ds",4.5f);
        Invoke("qiehuan", 4.5f);
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
        pic3.SetActive(false); 
    }

    private void qiehuan()
    {
        SceneManager.LoadScene("first");
    }
}
