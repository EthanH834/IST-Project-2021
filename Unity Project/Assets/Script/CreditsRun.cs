using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsRun : MonoBehaviour {

    public GameObject creditsRun;


	void Start () 
    {
        StartCoroutine(RollCreds());
	}

    IEnumerator RollCreds ()
    {
        yield return new WaitForSeconds(0.5f);
        creditsRun.SetActive(true);
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene(0);
    }
}