using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


[RequireComponent(typeof(ARRaycastManager))]//required components for code to work, to make it more safe to use
public class ARTapToPlaceObject : MonoBehaviour
{
    public GameObject socket; //object to place

    private GameObject spawnedSocket; //reference to object made
    private ARRaycastManager ARRaycastManager;
    private Vector2 touchPosition; //where we tap on screen to detect where to shoot our raycast and where to place object

    static List<ARRaycastHit> hits = new List<ARRaycastHit>();//reference of our raycast hits


    Camera Cam;
    // Start is called before the first frame update
    private void Awake()
    {
        ARRaycastManager = GetComponent<ARRaycastManager>();
    }

    bool TryGetTouchPosition(out Vector2 touchPosition)
    {
        if(Input.touchCount>0)
        {
            touchPosition = Input.GetTouch(0).position;
            return true;
        }
        touchPosition = default;
        return false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!TryGetTouchPosition(out Vector2 touchPosition))//if no touch detected
            return;

        //raycast takes touch position and number of hits and trackable types
        if(ARRaycastManager.Raycast(touchPosition,hits,TrackableType.PlaneWithinPolygon))
        {
            var hitPose = hits[0].pose;

            //make sure no object has been instantiated already if so i can place new one and move it around freely(we canm change it to be atleast 5 objects etc depends on our conditions)
            if(spawnedSocket==null)
            {
                spawnedSocket = Instantiate(socket, hitPose.position, hitPose.rotation);
                spawnedSocket.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f); //make socket small
              spawnedSocket.transform.localRotation = Quaternion.Euler(-90f, 0f, 0f);
              //spawnedSocket.transform.LookAt(Vector3.zero);



            }
            else
            {
                spawnedSocket.transform.position = hitPose.position;
            }

        }
    }
}
