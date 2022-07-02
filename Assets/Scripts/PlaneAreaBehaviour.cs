using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;

public class PlaneAreaBehaviour : MonoBehaviour
{public ARPlane arPlane;
    public   float area ;
    public Text txt;
    // Start is called before the first frame update
    // List<PlaneAreaBehaviour> planeAreaBehaviour = new List<PlaneAreaBehaviour>();

    void Update()
    {
    }
    void Start()
    {
        
        arPlane.boundaryChanged += ArPlane_BoundaryChanged;
    }

    private void ArPlane_BoundaryChanged(ARPlaneBoundaryChangedEventArgs obj)
    {
      
          area = CalculatePlaneArea(arPlane);
         txt.text = area.ToString();
         
        
    }
    
    private float CalculatePlaneArea(ARPlane plane)  
    {        
        return plane.size.x * plane.size.y;
    }

    public void setText()
    {
        float area = CalculatePlaneArea(arPlane);
          
        txt.text = area.ToString();
    }

   
    // Update is called once per frame
    
    public void ToggleAreaView()
    {
        
    }
}
