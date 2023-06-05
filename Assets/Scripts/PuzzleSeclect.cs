using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PuzzleSeclect : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject BackButton;

    public void SetPuzzleImage(Image photo)
    {
        for (int i = 0; i < 35; i++)
        {
            GameObject.Find("Piece (" + i + ")").transform.Find("Puzzle").GetComponent<SpriteRenderer>().sprite = photo.sprite;
        }
        MainMenu.SetActive(false);
        BackButton.SetActive(true);


    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
