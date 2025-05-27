using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButtonX : MonoBehaviour
{
    private Button button;
    private GameManagerX gameManagerX;
    public int difficulty;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerX = GameObject.Find("Game Manager")?.GetComponent<GameManagerX>();
        button = GetComponent<Button>();

        if (button == null)
        {
            Debug.LogError($"{gameObject.name}: Button component is missing!");
            return;
        }

        if (gameManagerX == null)
        {
            Debug.LogError($"{gameObject.name}: GameManagerX not found on 'Game Manager'");
            return;
        }

        //Debug.Log($"{gameObject.name}: Button and GameManagerX found.");
        button.onClick.AddListener(SetDifficulty);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log($"{gameObject.name}: Mouse clicked");
        }
    }



    /* When a button is clicked, call the StartGame() method
     * and pass it the difficulty value (1, 2, 3) from the button 
    */
    void SetDifficulty()
    {
        Debug.Log($"{button.gameObject.name} button clicked");
        Debug.Log(button.gameObject.name + " was clicked");
        gameManagerX.StartGame();
    }



}
