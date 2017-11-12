using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Restart : MonoBehaviour {
    public GameObject prefab;
    public GameObject currentCar;

	public void RestartGame(GameObject car){
        Destroy(currentCar);
        currentCar = (GameObject)Instantiate(prefab);
        Timer.needsReset = true;
    }
}
