using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject settingsMenu;
    public GameObject settingsButton;
    public GameObject backButton;
    public GameObject letterCanvas;

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    private void Update()
    {
        Settings();
        CursorLock();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void Settings()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            settingsMenu.gameObject.SetActive(!settingsMenu.gameObject.activeSelf);
            settingsButton.gameObject.SetActive(!settingsButton.gameObject.activeSelf);
        }
    }

    private void CursorLock()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }
        if (settingsMenu.gameObject.activeSelf == false && Input.GetKeyDown(KeyCode.Mouse1))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
