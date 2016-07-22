using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class narrativeScript : MonoBehaviour
{
    public Canvas storyMenu;
    public Button startText;
    public Button exitText;

   

    public void Startlevel()
    {
        Application.LoadLevel(2);
    }
    public void ExitGame()

    {
        Application.LoadLevel(0);
    }

    // Update is called once per frame
    void Update()
    {

    }
}