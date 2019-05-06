using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClicker : MonoBehaviour
{
    // Initialize Variables
    public GameObject mouseClickedImage;
    private IEnumerator mouseClick;

    // Start is called before the first frame update
    void Start()
    {
        // Used for the Controls UI to show how to pick up an object
        mouseClick = MouseClick();
        StartCoroutine(mouseClick);
    }

    IEnumerator MouseClick()
    {
        // Switches the mouse image shown in Controls menu
        for (; ; )
        {
            yield return new WaitForSeconds(1f);
            if (mouseClickedImage.activeInHierarchy == false)
            {
                mouseClickedImage.SetActive(true);
            }
            else if (mouseClickedImage.activeInHierarchy == true)
            {
                mouseClickedImage.SetActive(false);
            }
        }
    }
}
