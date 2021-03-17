using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameOverScr : MonoBehaviour
{
    public Text roflanText;

    public void setup(string roflanStr)
    {
        roflanText.text = roflanStr;
        this.gameObject.SetActive(true);
    }

    public void restartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
