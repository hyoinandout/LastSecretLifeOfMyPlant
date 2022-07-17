using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoilMoistureManager : MonoBehaviour
{
    public InputManager inputManager;

    public GameObject chFace;
    public Material yuck;
    public Material smile;
    public Material hungry;
    private void Start()
    {

    }
    private void Update()
    {
        if (inputManager.dirtMoisture > 250)
        {
            chFace.GetComponent<MeshRenderer>().material = hungry;
        }
        else if (inputManager.dirtMoisture < 100)
        {
            chFace.GetComponent<MeshRenderer>().material = yuck;
        }
        else
        {
            chFace.GetComponent<MeshRenderer>().material = smile;
        }
    }
    //멀리 있을 때는 다 자고 있는데
    //가까이 오면 180도 도는
}
