using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class rotating : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    public MeshRenderer hungry;
    public MeshRenderer temp;
    public MeshRenderer humid;
    public MeshRenderer lights;

    public Material smile;
    private int start = 0;
    void Update()
    {
        if(start==0)
        {
            this.transform.DOLocalRotate(new Vector3(0, 720, 0), 1.5f, RotateMode.FastBeyond360).SetRelative(true).SetEase(Ease.Linear);
            hungry.material = smile;
            temp.material = smile;
            humid.material = smile;
            lights.material = smile;
            start = 1;
        }
    }
}
