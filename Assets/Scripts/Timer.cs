using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {
	public Text timerText;
    public Text speedText;
    public static bool needsReset = false;
	private float startTime;

	// Use this for initialization
	void Start () {
		startTime = Time.time; 
	}
	
	// Update is called once per frame
	void Update () {
        while (!SampleApp.connected){
            startTime = Time.time;
            return;
        }
        if (needsReset){
            startTime = Time.time;
            needsReset = false;
        }
		float t = Time.time - startTime;
		string seconds = t.ToString ("f2");
		timerText.text = seconds;
        string speed = (CarController.movementSpeed * 100).ToString("f2");
        speedText.text = speed + " MPH";
	}
}
