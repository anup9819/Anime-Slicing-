using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuts : MonoBehaviour
{
    public GameObject knife;
    public AudioSource asmr;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.GetComponent<Collider>().enabled = true;
            knife.GetComponent<Animator>().SetBool("pressed", true);
        }
        if (Input.GetMouseButtonUp(0))
        {
            gameObject.GetComponent<Collider>().enabled = false;
            knife.GetComponent<Animator>().SetBool("pressed", false);

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "slices")
        {
            other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            other.gameObject.GetComponent<Rigidbody>().AddForceAtPosition(new Vector3(50f, 100f, 60f) * Random.Range(0.7f, 0.7f), new Vector3(0, -0.2f* Input.GetAxis("Vertical"), 0));
            asmr.Play();
            
        }
    }
}
