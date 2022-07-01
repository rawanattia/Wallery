using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchtime : MonoBehaviour
{
   public GameObject tmp;
    public List<GameObject> allbtns = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void click()
    {
          tmp = GameObject.Find("Socket 1");
        allbtns.Add(tmp);
        tmp.SetActive(false);

           tmp = GameObject.Find("Socket 2");
        allbtns.Add(tmp);
        tmp.SetActive(false);

           tmp = GameObject.Find("Light Switch 1");
        allbtns.Add(tmp);
        tmp.SetActive(false);

           tmp = GameObject.Find("Light Switch 2");
        allbtns.Add(tmp);
        tmp.SetActive(false);
       

    }

    public void dblclick()
    {
        foreach (GameObject btn in allbtns)
        {
            btn.SetActive(true);
        }


    }
}
