using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownController : MonoBehaviour
{
    public int countdownTime;
    public Text countdownDisplay;

    public int gameTimer = 60;
    public Text gameTimerDisplay;

    public Return_to_MainMenu c_RetToMenu;

    private void Start()
    {
        
    }

    public IEnumerator CountdownToStart()
    {
        while(countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();
            yield return new WaitForSeconds(1);
            countdownTime--;
        }

        countdownDisplay.text = "GO!";
        yield return new WaitForSeconds(1);
        countdownDisplay.gameObject.SetActive(false);
        StartCoroutine(CountdownToGameOver());
    } 

    IEnumerator CountdownToGameOver()
    {
        while(gameTimer > 0)
        {
            gameTimerDisplay.text = gameTimer.ToString();
            yield return new WaitForSeconds(1);
            gameTimer--;
        }

        gameTimerDisplay.text = "GAME OVER! Returning to main menu...";
        yield return new WaitForSeconds(5);
        c_RetToMenu.GAMEOVER = true;
        c_RetToMenu.Update();
    } 
}
