using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class interactionPopUp : MonoBehaviour
{
    [SerializeField]
    private GameObject interactText;

    [Header("Interact")]
    public string interact;

    void Start() 
    {
        interactText.GetComponent<Text>().text = interact;
        interactText.SetActive(false);
    }
    
	void Update () {
		if(Input.GetKeyDown("e")){
			interactText.SetActive(false);
		}
	}

    void OnTriggerEnter(Collider col) 
    {
        if (col.gameObject.tag == "Player")
        {
            interactText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            interactText.SetActive(false);
        }
    }
}
