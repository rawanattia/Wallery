using UnityEngine;
using UnityEngine.EventSystems;
public class addtofave : MonoBehaviour
{

    //public GameObject btn;
    public bool fave = false;
    public bool[] faved;
    // Start is called before the first frame update
    void Start()
    {
        faved = new bool[13];

        for (int i = 0; i < 13; i++)
        {
            faved[i] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void OnButtonDoubleClicked()
    {
        string name = EventSystem.current.currentSelectedGameObject.name;

      
        if (name == "Blue Button")
        {
            if (faved[0] == false)
                faved[0] = true;
            else
                faved[0] = false;
        }
        else if(name=="Green Button")
        {
            if (faved[1] == false)
                faved[1] = true;
            else
                faved[1] = false;
        }
        else if (name == "Purple Button")
        {
            if (faved[2] == false)
                faved[2] = true;
            else
                faved[2] = false;
        }
        else if (name == "Pink Button")
        {
            if (faved[3] == false)
                faved[3] = true;
            else
                faved[3] = false;
        }
        else if (name == "Red Button")
        {
            if (faved[4] == false)
                faved[4] = true;
            else
                faved[4] = false;
        }
        else if (name == "Orange Button")
        {
            if (faved[5] == false)
                faved[5] = true;
            else
                faved[5] = false;
        }
        else if (name == "Yellow Button")
        {
            if (faved[6] == false)
                faved[6] = true;
            else
                faved[6] = false;
        }
        else if (name == "Greenery Button")
        {
            if (faved[7] == false)
                faved[7] = true;
            else
                faved[7] = false;
        }
        else if (name == "Cherry Button")
        {
            if (faved[8] == false)
                faved[8] = true;
            else
                faved[8] = false;
        }
        else if (name == "Brick Button")
        {
            if (faved[9] == false)
                faved[9] = true;
            else
                faved[9] = false;
        }
        else if (name == "Ceramic Button")
        {
            if (faved[10] == false)
                faved[10] = true;
            else
                faved[10] = false;
        }
        else if (name == "Animals Button")
        {
            if (faved[11] == false)
                faved[11] = true;
            else
                faved[11] = false;
        }
        else if (name == "Wood Button")
        {
            if (faved[12] == false)
                faved[12] = true;
            else
                faved[12] = false;
        }

    }

  
}
