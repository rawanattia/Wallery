using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARPlaneChanger : MonoBehaviour
{
    public Material[] mats;//list of materials, will have the materials we want to set
    private int pos = 0; //position holder, 0 as of this script

    public MeshRenderer currentGroundPlane;//need to be able to have access to plane prefab(AR plane debug) in ar plane manager in ar session origin (or atleast the mesh of it), we used meshrenderer as the type and not just renderer because renderer could be a line or mesh


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //when ChangePlaneBtn gets pressed we want to call this function, it goes to the next position, and it sets the current ground material to the pos which points to corresponding texture
    public void NextPlane()
    {
        pos = pos + 1;
        if (pos >= mats.Length)
        {
            pos = 0;
        }

        //function used to change all current detected planes to the current choosen texture
        SetPosTo(pos);
    }

    public void SetPosTo(int newPos)
    {
        pos = newPos;

        //trackables;different detected planes
        MeshRenderer[] rends = transform.GetComponentsInChildren<MeshRenderer>(); //looks for all the components in the children that have a meshrenderer 

        //changes all current detected planes to the current choosen texture
        for (int i = 0; i < rends.Length; i++)
        {
            rends[i].material = mats[pos];
        }

        currentGroundPlane.material = mats[pos];
    }



}
