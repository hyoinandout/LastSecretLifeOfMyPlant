using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO.Ports;
public class InputManager : MonoBehaviour
{
    SerialPort arduino = new SerialPort("COM3", 9600);
    private string inputData;
    private string[] splitedInputData;
    private string[] splitedTempMoist;
    private string inputdataType;

    public float light;
    public float moisture;
    public float temperature;
    public float dirtMoisture;
    public float distance_1;
    public Vector3 currentPosition;



    // Start is called before the first frame update
    void Start()
    {
        arduino.Open();
    }

    // Update is called once per frame
    void Update()
    {
        inputData = arduino.ReadLine();
        splitedInputData = inputData.Split(':');

        if (splitedInputData[0] == "3") //조도
        {
            light = float.Parse(splitedInputData[1]);
            //Debug.Log(light);
        }
        else if (splitedInputData[0] == "1") //토양습도
        {
            dirtMoisture = float.Parse(splitedInputData[1]);
            //Debug.Log(dirtMoisture);
        }
        else if (splitedInputData[0] == "2") //습도
        {
            splitedTempMoist = splitedInputData[1].Split(' ');
            moisture = float.Parse(splitedTempMoist[0]);
            temperature = float.Parse(splitedTempMoist[1]);
        }
        else if (splitedInputData[0] == "4") //초음파1
        {
            distance_1 = float.Parse(splitedInputData[1]);
        }
    }
}