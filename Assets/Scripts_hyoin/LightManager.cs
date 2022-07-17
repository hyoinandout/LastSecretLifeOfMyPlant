using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LightManager : MonoBehaviour
{

    public InputManager inputManager;
    //public Image backgroundImage;
    private Color32 tempLight;
    public Light roomLight;

    public GameObject chFace;
    public Material smile;
    public Material depress;
    public float lightNow;
    [Range(0, 255)]
    public byte intensity;

    private void Start()
    {
        intensity = 255;
        tempLight = new Color32(255, 255, 255, 255);
    }
    private void Update()
    {
        lightNow = inputManager.light;
        intensity = (byte)lightNow;
        tempLight.r = intensity;
        tempLight.g = intensity;
        tempLight.b = intensity;
        roomLight.color = tempLight;
        //backgroundImage.color = tempLight;

        if (lightNow < 200)
        {
            chFace.GetComponent<MeshRenderer>().material = depress;
        }
        else
        {
            chFace.GetComponent<MeshRenderer>().material = smile;
        }
    }
    // ������ ���� ǥ�� ��ȭ�� ����.
    // �̸��� �� ���̰� �ִ� �ְ� ���� ���� ���Ϸ� �������� ���������.
}
