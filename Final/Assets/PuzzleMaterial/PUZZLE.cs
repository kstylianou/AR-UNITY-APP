using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PUZZLE : MonoBehaviour 
{
    [Header("Markers")]
    public Text countText;
    public Text markerHelper;

    [Header("Countdown")]
    public Text timeText;
    public static int puzzle;


    public bool isRunning = false;

    public Material[] material;

    private bool startGame = false;
    private bool startCountdown = false;
    private float timeRemaining = 4;
    private int countConnectedPieces = 0;
    private bool puzzle_1_2 = false;
    private bool puzzle_1_3 = false;
    private bool puzzle_2_4 = false;
    private bool puzzle_3_4 = false;


    [Header("Puzzle Pieces")]
    public GameObject puzzle1;
    public GameObject puzzle2;
    public GameObject puzzle3;
    public GameObject puzzle4;



    public void SetPuzzle(int i)
    {
        puzzle = i;
    }


    void Start()
    {

        Debug.Log(puzzle);
        if(puzzle == 2 && isRunning)
        {
            puzzle1.GetComponent<Renderer>().material = material[0];
            puzzle2.GetComponent<Renderer>().material = material[1];
            puzzle3.GetComponent<Renderer>().material = material[2];
            puzzle4.GetComponent<Renderer>().material = material[3];
        }

        if(puzzle == 3 && isRunning)
        {
            puzzle1.GetComponent<Renderer>().material = material[4];
            puzzle2.GetComponent<Renderer>().material = material[5];
            puzzle3.GetComponent<Renderer>().material = material[6];
            puzzle4.GetComponent<Renderer>().material = material[7];
        }
        
    }

    void Update()
    {
        if (startGame)
        {
            DisplayConnectedPieces();

            if (collision_p1_2.snapped == true && collision_p1_3.snapped == true && collision_p2_4.snapped == true && collision_p3_4.snapped == true)
            {
                SceneManager.LoadScene("Congradulations");
                collision_p1_2.snapped = false;
                collision_p1_3.snapped = false;
                collision_p2_4.snapped = false;
                collision_p3_4.snapped = false;
                MyDefaultTrackableEventHandler.countNum = 0;
            }
                
        }
        else
        {
            countText.text = "Markers Found: " + MyDefaultTrackableEventHandler.countNum + "/4";

            if (MyDefaultTrackableEventHandler.countNum == 4)
            {
                //countText.gameObject.SetActive(false);
                markerHelper.text = "Complete the puzzle !!!";
                if (!startGame)
                {
                    startCountdown = true;
                }

            }


            if (startCountdown)
            {
                if (timeRemaining > 0)
                {
                    timeRemaining -= Time.deltaTime;
                    DisplayTime(timeRemaining);
                }
                else
                {
                    startGame = true;
                    timeText.gameObject.SetActive(false);
                }
            }
        }

        
    }


    void DisplayTime(float timeToDisplay)
    {
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        if (seconds != 0)
            timeText.text = seconds + "";
        else
        {
            timeText.text = "Good Luck!";
        }
    }

    void DisplayConnectedPieces()
    {
        if (collision_p1_2.snapped == true)
        {
            if (!puzzle_1_2)
            {
                countConnectedPieces++;
                puzzle_1_2 = true;
            }
        }
        else
        {
            if (puzzle_1_2)
            {
                countConnectedPieces--;
                puzzle_1_2 = false;
            }
        }

        if (collision_p1_3.snapped == true)
        {
            if (!puzzle_1_3)
            {
                countConnectedPieces++;
                puzzle_1_3 = true;
            }
        }
        else
        {
            if (puzzle_1_3)
            {
                countConnectedPieces--;
                puzzle_1_3 = false;
            }
        }

        if (collision_p2_4.snapped == true)
        {
            if (!puzzle_2_4)
            {
                countConnectedPieces++;
                puzzle_2_4 = true;
            }
        }
        else
        {
            if (puzzle_2_4)
            {
                countConnectedPieces--;
                puzzle_2_4 = false;
            }
        }

        if (collision_p3_4.snapped == true)
        {
            if (!puzzle_3_4)
            {
                countConnectedPieces++;
                puzzle_3_4 = true;
            }
        }
        else
        {
            if (puzzle_3_4)
            {
                countConnectedPieces--;
                puzzle_3_4 = false;
            }
        }

        countText.text = "Connected pieces: " + countConnectedPieces + "/4";
    }
}
