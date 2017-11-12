using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {

    public static float movementSpeed;
	private float speed;
	private float maxSpeed;
	private float rotSpeed;

	// Use this for initialization
	void Start () {
		speed = 20f;
		rotSpeed = 110f;
	}

	// Update is called once per frame
	void Update () {
        if (!SampleApp.connected){
            return;
        }

		var x = (Time.deltaTime * (rotSpeed * SampleApp.headRotation * -1));
		var z = (Time.deltaTime * (speed * SampleApp.speedMultiplier));

        movementSpeed = z;
		transform.Rotate(0, 0, x);
		transform.Translate(0, -z, 0);

	}
}
	