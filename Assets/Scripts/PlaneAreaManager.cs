using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;


public class PlaneAreaManager : MonoBehaviour
{
     void Start()
    {
        
    

    }
    public Text txt;
    List<PlaneAreaBehaviour> planeAreaBehaviours = new List<PlaneAreaBehaviour>();
    // Update is called once per frame
    public void setEstimation(){
        float totalArea = 0;
        foreach( var plane in planeAreaBehaviours ) {
        totalArea  += plane.area;
        }

        //each paint buckets covcers 6 m^2
        totalArea /= 6;
        if(totalArea == 0)
        {
            txt.text = "No plane detected yet";
        }
        else if(totalArea < 1)
        {
        txt.text = "1 small bucket";

        }
        else if(totalArea < 3)
        {
            txt.text = "1 medium bucket";
        }
        else
        {
            int numberOfBuckets =(int) totalArea;
            string output = numberOfBuckets.ToString() + " buckets";
            txt.text = output;
        }
        
    }
   
    void Update()
    {
        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Ended)
            {
                if (Input.touchCount == 1)
                {
                    Ray raycast = Camera.main.ScreenPointToRay(touch.position);
                        if (Physics.Raycast(raycast, out RaycastHit raycastHit)) {
                                var planeAreaBehaviour = raycastHit.collider.gameObject.GetComponent<PlaneAreaBehaviour>();

                                if (planeAreaBehaviour != null)
                                {
                                     planeAreaBehaviours.Add(planeAreaBehaviour);
                                    planeAreaBehaviour.ToggleAreaView();
                                }
                        }

                } 
            }
        }
    }
}
