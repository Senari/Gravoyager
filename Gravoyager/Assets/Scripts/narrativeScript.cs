using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class narrativeScript : MonoBehaviour
{
    public Canvas storyMenu;
    public Button startText;
    public Button exitText;


    public void Startinfo()
    {
        Application.LoadLevel(1);
    }

    public void Startstory()
    {
        Application.LoadLevel(2);
    }

    public void Startlevel()
    {
        Application.LoadLevel(3);
    }


    public void Startlevel2info()
    {
        Application.LoadLevel(6);
    }
    public void Startlevel2()
    {
        Application.LoadLevel(7);
    }
    public void Startlevel3info()
    {
        Application.LoadLevel(8);
    }
    public void Startlevel3()
    {
        Application.LoadLevel(9);
    }
    public void Startlevel4info()
    {
        Application.LoadLevel(10);
    }
    public void Startlevel4()
    {
        Application.LoadLevel(11);
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