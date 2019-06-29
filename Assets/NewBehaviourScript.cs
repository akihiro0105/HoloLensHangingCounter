using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

    [SerializeField] private Text countText;

    private int count = 0;
	// Use this for initialization
	void Start () {
        countText.text = count.ToString();
    }

    private void OnTriggerExit(Collider other)
    {
        count++;
        countText.text = count.ToString();
    }
}
