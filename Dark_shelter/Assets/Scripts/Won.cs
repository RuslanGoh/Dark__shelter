using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Won : MonoBehaviour {

    public GameObject dialogBox;
    public Text dialogText;
    public Transform target;
    void Start()
    {
        
        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update() {

        if (Vector3.Distance(target.position, transform.position) < 1)
        {
            dialogText.text = "YOU WON";
            dialogBox.SetActive(true);
            GameObject.FindWithTag("Player").SetActive(false);
            GameObject.FindWithTag("vision").SetActive(false);
        }
       
    }
}
