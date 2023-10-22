using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject player1End;
    public GameObject player2End;

    public float restartDelay = 5f;

    public void OnPlayer1Death()
    {
        player1End.SetActive(true);
        player1End.GetComponent<AudioSource>()?.Play();
        Invoke(nameof(Reset), restartDelay);
    }

    public void OnPlayer2Death()
    {
        player2End.SetActive(true);
        player2End.GetComponent<AudioSource>()?.Play();
        Invoke(nameof(Reset), restartDelay);
    }

    private void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
