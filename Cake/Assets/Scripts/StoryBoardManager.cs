using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryBoardManager : MonoBehaviour
{
    
    public  GameObject StoryBoardPanel;
    public  GameObject ExitStoryButton;
    public  GameObject NextStoryButton;
    public  GameObject PreviousStoryButton;
    public  GameObject StoryBoardMenu;
    public  GameObject StartStoryButton;
    public  Sprite[] StoryBoard;
    int currentStory=0;

    public void StartStory()
    {
        StoryBoardMenu.SetActive(true);
        StoryBoardPanel.SetActive(true);
        PreviousStoryButton.SetActive(false);
        StartStoryButton.SetActive(true);
        ExitStoryButton.SetActive(false);
    }

    public void ExitStory()
    {
        StoryBoardPanel.SetActive(false);
        ExitStoryButton.SetActive(false);
    }

    public void nextStory()
    {
        switch (currentStory)
        {
            case 0:
                currentStory++;
                GameObject.Find("StoryBoardPanel").GetComponent<Image>().sprite = StoryBoard[currentStory];
                PreviousStoryButton.SetActive(true);
                NextStoryButton.SetActive(true);
                ExitStoryButton.SetActive(false);
                break;
            case 1:
                currentStory++;
                GameObject.Find("StoryBoardPanel").GetComponent<Image>().sprite = StoryBoard[currentStory];
                PreviousStoryButton.SetActive(true);
                NextStoryButton.SetActive(true);
                ExitStoryButton.SetActive(true);
                break;
            case 2:
                currentStory++;
                GameObject.Find("StoryBoardPanel").GetComponent<Image>().sprite = StoryBoard[currentStory];
                PreviousStoryButton.SetActive(true);
                NextStoryButton.SetActive(false);
                ExitStoryButton.SetActive(true);
                StartStoryButton.SetActive(true);
                break;
            /*case 3:
                currentStory++;
                GameObject.Find("StoryBoardPanel").GetComponent<Image>().sprite = StoryBoard[currentStory];
                PreviousStoryButton.SetActive(false);
                StartStoryButton.SetActive(true);
                ExitStoryButton.SetActive(true);
                break;*/
        }
    }
    public void previousStory()
    {
        switch (currentStory)
        {
            case 0:
                currentStory++;
                GameObject.Find("StoryBoardPanel").GetComponent<Image>().sprite = StoryBoard[currentStory];
                PreviousStoryButton.SetActive(true);
                NextStoryButton.SetActive(true);
                ExitStoryButton.SetActive(false);
                break;
            case 1:
                currentStory++;
                GameObject.Find("StoryBoardPanel").GetComponent<Image>().sprite = StoryBoard[currentStory];
                PreviousStoryButton.SetActive(true);
                NextStoryButton.SetActive(true);
                ExitStoryButton.SetActive(false);
                break;
            case 2:
                currentStory++;
                GameObject.Find("StoryBoardPanel").GetComponent<Image>().sprite = StoryBoard[currentStory];
                PreviousStoryButton.SetActive(true);
                NextStoryButton.SetActive(true);
                ExitStoryButton.SetActive(false);
                break;
            case 3:
                currentStory++;
                GameObject.Find("StoryBoardPanel").GetComponent<Image>().sprite = StoryBoard[currentStory];
                PreviousStoryButton.SetActive(true);
                StartStoryButton.SetActive(true);
                ExitStoryButton.SetActive(false);
                break;
        }
    }

}
