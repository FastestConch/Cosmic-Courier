using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Planet : MonoBehaviour
{
    public float sizeMultiplier = 2f;
    public bool inRange = false;
    public string sceneName;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            this.transform.localScale = Vector3.one * sizeMultiplier;

            inRange = true;
        }
    }

    public void Update()
    {
        if(inRange == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("PRESSED");

                SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
            }
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            this.transform.localScale = Vector3.one;
        }
    }
}
