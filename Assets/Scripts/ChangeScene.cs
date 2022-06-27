using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
  
    //loads scene that we want
    public void MoveToScene(int SceneID)
    {
        SceneManager.LoadScene(SceneID);
    }


}
