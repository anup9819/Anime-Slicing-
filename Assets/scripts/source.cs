using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class source : MonoBehaviour
{
    public GameObject potato, onion, tomato,parent;
    GameObject _temp;
    int t,ran;
    public int time_out;
    // Start is called before the first frame update
    void Start()
    {
        t = time_out;
    }

    // Update is called once per frame
    void Update()
    {
        t += 1;
        if (t > time_out)
        {
            ran = Random.Range(0, 1000);
            if (ran <= 330) { _temp = Instantiate(potato); }
            if (ran > 330 && ran<=660) { _temp = Instantiate(tomato); }
            if (ran > 660) { _temp = Instantiate(onion); }
         


            _temp.transform.position +=new Vector3(0,0, gameObject.transform.position.z);
            _temp.transform.SetParent(parent.transform);
            t = 0;
        }
    }
}
