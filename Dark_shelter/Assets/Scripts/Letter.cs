using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Letter : MonoBehaviour
{
	public GameObject dialogBox;
	public Text dialogText;
	public string dialog;
	public bool playerInRange;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && playerInRange)
        {
        	if(dialogBox.activeInHierarchy)
        	{
        		dialogBox.SetActive(false);
        	}
        	else
        	{
        		dialogBox.SetActive(true);
        		dialogText.text = dialog;
        	}
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
    	if(collision.CompareTag("Player"))
    	{
    		playerInRange = true;
    	}
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
    	if(collision.CompareTag("Player"))
    	{
    		playerInRange = false;
    		dialogBox.SetActive(false);
    	}
    }
}
