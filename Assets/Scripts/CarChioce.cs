using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChioce : MonoBehaviour {

    public GameObject RedBody;
    public GameObject BlueBody;
    public GameObject GreenBody;
    public int carImport = 1;
	// Use this for initialization
	void Start () {
        carImport = GlobalCar.CarType;
        if(carImport == 1){
            RedBody.SetActive(true);
        }
        if(carImport == 2){
            BlueBody.SetActive(true);
        }
        if (carImport == 3)
        {
            GreenBody.SetActive(true);
        }
	}
	
}
