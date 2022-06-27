using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


[RequireComponent(typeof(ARRaycastManager))] //because we will call some funcyions from this class, so now we can see the araycastmanager class
public class SpawnObjects : MonoBehaviour
{
    private ARRaycastManager raycastManager;
    private GameObject spawnedObject;
    private List<GameObject> placedPrefabList = new List<GameObject>();

    [SerializeField]
    private int maxPrefabSpawnCount = 0;
    private int placedPrefabCount;

   

    //for the prefab we'll be placing into the world
    [SerializeField]
    private GameObject placeablePrefab;

    static List<ARRaycastHit> s_Hits = new List<ARRaycastHit>();

    private void Awake()
    {
        raycastManager = GetComponent<ARRaycastManager>();

    }

    //recording where user is pressing on the screen
    bool TryGetTouchPosition(out Vector2 touchPosition)
    {
        if(Input.GetTouch(0).phase == TouchPhase.Began)
        {
            //store first touch as input
            touchPosition = Input.GetTouch(0).position;
            return true;
        }
        touchPosition = default;
        return false;
    }

    private void Update()
    {
        //check if we have a valid touch or not, if not return aka dont update
        if(!TryGetTouchPosition(out Vector2 touchPosition))
        {
            return;
        }

        //valid touch? therefore we raycast into the world and check whether the touch is hitting a trackable that is stored
        if(raycastManager.Raycast(touchPosition,s_Hits,TrackableType.PlaneWithinPolygon))
        {
            var hitPose = s_Hits[0].pose;

            if (placedPrefabCount == 0)
            {
                SpawnPrefab(hitPose);

            }
            else if(placedPrefabCount==1)
            {
                foreach (GameObject gameObject in placedPrefabList)
                {
                    Object.Destroy(gameObject);
                }
                placedPrefabList.Clear();
                placedPrefabCount = 0;
                SpawnPrefab(hitPose);
            }
  
        }
 
    }
    public void SetPrefabType(GameObject prefabType)
    {
        placeablePrefab = prefabType;
    }

    private void SpawnPrefab(Pose hitPose)
    {
        spawnedObject = Instantiate(placeablePrefab, hitPose.position, hitPose.rotation);//we place the placeable prefab at the the hit pose
        spawnedObject.transform.localScale = new Vector3(0.001f, 0.001f, 0.001f); //make socket small
        //spawnedObject.transform.localPosition = new Vector3(hitPose.position.x, -hitPose.position.y, hitPose.position.z);
        spawnedObject.transform.localRotation = Quaternion.Euler(0f, -180f, 0f);
        placedPrefabList.Add(spawnedObject);
        placedPrefabCount++;
    }

}

