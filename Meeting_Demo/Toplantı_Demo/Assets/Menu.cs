using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
    public void StartMain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   // Sahne indexini 1 arttýrýyor (Oyun sahnesine geçmek için)
    }

    public void Quit()
    {
        Application.Quit();                              // .exe Dosyalarýný durdurmak için 
        UnityEditor.EditorApplication.isPlaying = false; // Unity Play Modunu durdurmak için -> Bool deðerini false yap
        Debug.Log("Close");                              // Debug.Log kontrolü
    }
    public void BackToMenu() { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);   // Sahne indexini 1 azaltýyor (Menü sahnesine dönmek için)
    }
}
