using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoistureManager : MonoBehaviour
{
    public InputManager inputManager;

    public GameObject chFace;
    public Material mad;
    public Material smile;
    public int moistureOk = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (inputManager.moisture > 65)
        {
            chFace.GetComponent<MeshRenderer>().material = mad;
            moistureOk = 0;
        }
        else
        {
            chFace.GetComponent<MeshRenderer>().material = smile;
            moistureOk = 1;
        }
    }
}
