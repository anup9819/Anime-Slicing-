using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public Animator mainscenebuttonanim;

    private void Start()
    {
    }
    // Update is called once per frame
    public void mainmenuplay()
    {

        
        StartCoroutine(mainscene());
        
    }
    IEnumerator mainscene()
    {
        
        mainscenebuttonanim.SetTrigger("start");
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(1);
    }
}