using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Return_to_MainMenu : MonoBehaviour
{
    public bool GAMEOVER = false;

    public void Update()
{
    if (Input.GetKeyDown(KeyCode.Escape) || GAMEOVER)
    {
        Debug.Log("quit! success");
        SceneManager.UnloadSceneAsync (SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(0);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}

}
