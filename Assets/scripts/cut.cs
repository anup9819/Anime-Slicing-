using UnityEngine;

public class cut : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource cutting;
    public GameObject Knife;
    public GameObject score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.GetComponent<Collider>().enabled = true;
            Knife.GetComponent<Animator>().SetBool("isPress", true);
        }
        if (Input.GetMouseButtonUp(0))
        {
            gameObject.GetComponent<Collider>().enabled =false;
            Knife.GetComponent<Animator>().SetBool("isPress", false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "slices")
        {
            other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            other.gameObject.GetComponent<Rigidbody>().AddForceAtPosition(new Vector3(50f,100f,60f)*Random.Range(0.75f,1.5f), new Vector3(0, -1f, 0));
            cutting.Play();
            score.transform.position += new Vector3(0.3f, 0, 0);
        }
    }
}
