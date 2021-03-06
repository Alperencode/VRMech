using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public AudioSource buttonSound;
    public void StartMain()
    {
        DontDestroyOnLoad(buttonSound);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   // Sahne indexini 1 artt?r?yor (Oyun sahnesine ge?mek i?in)
    }

    public void Quit()
    {
        DontDestroyOnLoad(buttonSound);
        Application.Quit();                              // .exe Dosyalar?n? durdurmak i?in 
        UnityEditor.EditorApplication.isPlaying = false; // Unity Play Modunu durdurmak i?in -> Bool de?erini false yap
        Debug.Log("Close");                              // Debug.Log kontrol?
    }
    public void BackToMenu() { 
        DontDestroyOnLoad(buttonSound);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);   // Sahne indexini 1 azalt?yor (Men? sahnesine d?nmek i?in)
    }
}
