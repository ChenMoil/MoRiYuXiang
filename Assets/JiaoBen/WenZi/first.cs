using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class first : MonoBehaviour
{
    public Text Me ;
    public GameObject next;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TypeText(Me, "异乡人, 你知道你在做什么吗？", 0.2f));
        Invoke("gonext",3.5f);
        Invoke("ds", 5.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void gonext()
    {
        next.SetActive(true);
    }

    void ds()
    {
        gameObject.SetActive(false);
    }
    IEnumerator TypeText(Text me, string str, float speed)
    {
        int i = 0;
        while (i <= str.Length)
        {
            me.text = str.Substring(0, i++);
            yield return new WaitForSeconds(speed);
        }
    }
}
