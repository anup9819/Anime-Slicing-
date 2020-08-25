using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelselector : MonoBehaviour
{

    public Animator buttonAnim;


    public void playgame()
    {


        StartCoroutine(loadscene());

    }


    IEnumerator loadscene()
    {
        buttonAnim.GetComponent<Animator>().SetTrigger("buttonanim");
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(2);
    }





}
