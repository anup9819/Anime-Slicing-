using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelselector4 : MonoBehaviour
{

    public Animator ButtonAnim;
    
    
    public void playgame()
    {


        StartCoroutine(loadscene());

    }
    
    
        IEnumerator loadscene()
        {
        ButtonAnim.GetComponent<Animator>().SetTrigger("buttonanim");
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene(5);
        }
        
    
}
