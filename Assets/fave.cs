using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
public class fave : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject scrollview;
    public GameObject tempbtn;
    public addtofave script;

    public bool on=false;
    public bool[] faved2;

    public List<GameObject> allbtns = new List<GameObject>();

    void Start()
    {

        faved2 = new bool[13];

        for (int i = 0; i < 13; i++)
        {
            faved2[i] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonClicked()
    {
        string name = EventSystem.current.currentSelectedGameObject.name;
        if (name=="Fave")
        {
            for (int i = 0; i < script.faved.Length; i++)
            {
                faved2[i] = script.faved[i];
            }

            if (faved2[0] == false)
            {
                tempbtn = GameObject.Find("Blue Button");
                allbtns.Add(tempbtn);
                tempbtn.SetActive(false);
            }

            if (faved2[1] == false)
            {
                tempbtn = GameObject.Find("Green Button");
                allbtns.Add(tempbtn);
                tempbtn.SetActive(false);
            }

            if (faved2[2] == false)
            {
                tempbtn = GameObject.Find("Purple Button");
                allbtns.Add(tempbtn);
                tempbtn.SetActive(false);
            }

            if (faved2[3] == false)
            {
                tempbtn = GameObject.Find("Pink Button");
                allbtns.Add(tempbtn);
                tempbtn.SetActive(false);
            }

            if (faved2[4] == false)
            {
                tempbtn = GameObject.Find("Red Button");
                allbtns.Add(tempbtn);
                tempbtn.SetActive(false);
            }

            if (faved2[5] == false)
            {
                tempbtn = GameObject.Find("Orange Button");
                allbtns.Add(tempbtn);
                tempbtn.SetActive(false);
            }

            if (faved2[6] == false)
            {
                tempbtn = GameObject.Find("Yellow Button");
                allbtns.Add(tempbtn);
                tempbtn.SetActive(false);
            }

            if (faved2[7] == false)
            {
                tempbtn = GameObject.Find("Greenery Button");
                allbtns.Add(tempbtn);
                tempbtn.SetActive(false);
            }

            if (faved2[8] == false)
            {
                tempbtn = GameObject.Find("Cherry Button");
                allbtns.Add(tempbtn);
                tempbtn.SetActive(false);
            }

            if (faved2[9] == false)
            {
                tempbtn = GameObject.Find("Brick Button");
                allbtns.Add(tempbtn);
                tempbtn.SetActive(false);
            }

            if (faved2[10] == false)
            {
                tempbtn = GameObject.Find("Ceramic Button");
                allbtns.Add(tempbtn);
                tempbtn.SetActive(false);
            }

            if (faved2[11] == false)
            {
                tempbtn = GameObject.Find("Animals Button");
                allbtns.Add(tempbtn);
                tempbtn.SetActive(false);
            }

            if (faved2[12] == false)
            {
                tempbtn = GameObject.Find("Wood Button");
                allbtns.Add(tempbtn);
                tempbtn.SetActive(false);
            }
            // on = true;
        }
        
        else if(name=="all colours")
        {

            foreach (GameObject btn in allbtns)
            {
                btn.SetActive(true);
            }
          //  on = false;
        }

       
       /* if (scrollview.activeInHierarchy == true)
         {
             scrollview.SetActive(false);

         }
         else
             scrollview.SetActive(true);*/
       
    }
}
