using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
public class estimatesupplies : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject estimatecontainer;


    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnEstimateButtonClicked()
    {
        

            estimatecontainer.SetActive(true);

     
       
    }

    public void OnExitClicked()
    {
        

            if (estimatecontainer.activeInHierarchy == true)
            {
                estimatecontainer.SetActive(false);
            }
        



    }
}
