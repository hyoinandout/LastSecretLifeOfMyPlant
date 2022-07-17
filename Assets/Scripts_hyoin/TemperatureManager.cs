using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemperatureManager : MonoBehaviour
{
    public InputManager inputManager;

    public GameObject chFace;
    public Material smile;
    public Material hot;
    public Material cold;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (inputManager.temperature > 28)
        {
            chFace.GetComponent<MeshRenderer>().material = hot;
        }
        else if (inputManager.temperature < 15)
        {
            chFace.GetComponent<MeshRenderer>().material = cold;
        }
        else
        {
            chFace.GetComponent<MeshRenderer>().material = smile;
        }
    }
}
