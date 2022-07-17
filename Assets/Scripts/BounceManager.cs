using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceManager : MonoBehaviour
{
    public SoilMoistureManager soilMoistureManager;
    public TemperatureManager temperatureManager;
    public LightManager lightManager;
    public MoistureManager moistureManager;
    // Start is called before the first frame update

    public GameObject hungryface;
    public GameObject tempface;
    public GameObject moistureface;
    public GameObject lightface;

    private Vector3 upVector = new Vector3(0.0f, 300.0f, 0.0f);
    private int bounce;

    // Update is called once per frame
    void Update()
    {
        bounce = soilMoistureManager.soilOk + temperatureManager.tempOk + lightManager.lightOk + moistureManager.moistureOk;
        if(bounce >= 3)
        {
            if(hungryface.GetComponent<BoxCollider>().material.bounceCombine == PhysicMaterialCombine.Minimum)
            {
                hungryface.GetComponent<BoxCollider>().material.bounceCombine = PhysicMaterialCombine.Maximum;
                hungryface.GetComponent<Rigidbody>().AddForce(upVector, ForceMode.Force);

                tempface.GetComponent<BoxCollider>().material.bounceCombine = PhysicMaterialCombine.Maximum;
                tempface.GetComponent<Rigidbody>().AddForce(upVector, ForceMode.Force);


                moistureface.GetComponent<BoxCollider>().material.bounceCombine = PhysicMaterialCombine.Maximum;
                moistureface.GetComponent<Rigidbody>().AddForce(upVector, ForceMode.Force);


                lightface.GetComponent<BoxCollider>().material.bounceCombine = PhysicMaterialCombine.Maximum;
                lightface.GetComponent<Rigidbody>().AddForce(upVector, ForceMode.Force);
            }
        }
        else
        {
            hungryface.GetComponent<BoxCollider>().material.bounceCombine = PhysicMaterialCombine.Minimum;
            tempface.GetComponent<BoxCollider>().material.bounceCombine = PhysicMaterialCombine.Minimum;
            moistureface.GetComponent<BoxCollider>().material.bounceCombine = PhysicMaterialCombine.Minimum;
            lightface.GetComponent<BoxCollider>().material.bounceCombine = PhysicMaterialCombine.Minimum;
        }
    }
}
