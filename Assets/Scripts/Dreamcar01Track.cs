using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dreamcar01Track : MonoBehaviour
{

    public GameObject TheMarker;
    public GameObject Mark01;
    public GameObject Mark02;
    public GameObject Mark03;
    public GameObject Mark04;
    public GameObject Mark05;
    public GameObject Mark06;
    public GameObject Mark07;
    private int MarkTracker;

	private void Start()
	{
        MarkTracker = 0;
        TheMarker.transform.position = Mark01.transform.position;
	}

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Dreamcar01")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            MarkTracker += 1;
            if (MarkTracker == 7)
            {
                MarkTracker = 0;
            }

            if (MarkTracker == 0){
                TheMarker.transform.position = Mark01.transform.position;
            } else if (MarkTracker == 1)
            {
                TheMarker.transform.position = Mark02.transform.position;
            } else if (MarkTracker == 2)
            {
                TheMarker.transform.position = Mark03.transform.position;
            } else if (MarkTracker == 3)
            {
                TheMarker.transform.position = Mark04.transform.position;
            } else if (MarkTracker == 4)
            {
                TheMarker.transform.position = Mark05.transform.position;
            } else if (MarkTracker == 5)
            {
                TheMarker.transform.position = Mark05.transform.position;
            } else {
                TheMarker.transform.position = Mark06.transform.position;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}