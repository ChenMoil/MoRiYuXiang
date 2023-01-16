using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shan : MonoBehaviour
{
    public GameObject wh;
    public GameObject re;
    public GameObject next;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shan(wh , re , next));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Shan(GameObject color ,GameObject color2 ,GameObject next)
    {
        color.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        color.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        color.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        color.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        color2.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        color2.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        next.SetActive(true);
        gameObject.SetActive(false);
    }
}
