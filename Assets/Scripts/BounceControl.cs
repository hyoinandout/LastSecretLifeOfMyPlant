using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceControl : MonoBehaviour
{
    private Vector3 upVector = new Vector3(0.0f, 300.0f, 0.0f);
    //public PhysicMaterial stall;
    // Start is called before the first frame update

    public PhysicMaterial bounce;
    void Start()
    {
        this.gameObject.GetComponent<BoxCollider>().material.bounceCombine = PhysicMaterialCombine.Maximum;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.transform.GetComponent<BoxCollider>().material = bounce;
            this.transform.GetComponent<Rigidbody>().AddForce(upVector, ForceMode.Force);
        }
        else if(Input.GetKeyDown(KeyCode.K))
        {
            if(this.gameObject.GetComponent<BoxCollider>().material.bounceCombine == PhysicMaterialCombine.Maximum)
            {
                this.gameObject.GetComponent<BoxCollider>().material.bounceCombine = PhysicMaterialCombine.Minimum;
            }
            else
            {
                this.gameObject.GetComponent<BoxCollider>().material.bounceCombine = PhysicMaterialCombine.Maximum;
                this.gameObject.GetComponent<Rigidbody>().AddForce(upVector, ForceMode.Force);
            }
        }
    }
}
