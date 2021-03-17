using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public bool gameHasEnded = false;

    public gameOverScr GOS;

    private GameObject player;
    private playerScr playerS;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerS = player.GetComponent<playerScr>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void endGame()
    {
        gameHasEnded = true;
        if (playerS.roflanState == 0)
            GOS.setup("ті розбівся (ті розбійник)");
        else
            GOS.setup("roflanOver");
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //SceneManager.LoadScene("Level1");
    }
}
