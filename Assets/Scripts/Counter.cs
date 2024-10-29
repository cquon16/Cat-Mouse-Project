using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Counter : MonoBehaviour
{
    public TMP_Text mouseText;

    public int mouses = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouseText.text = "Mouses: " + mouses + "/6";

        if (mouses == 6)
        {
            SceneManager.LoadScene(3);
        }
    }
}
