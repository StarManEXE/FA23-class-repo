using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TalkToLoveBug : MonoBehaviour
{
    public string[] story = new string[17]; //number can be anything. As long as you want to write.
    private int _storyindex;
    public string sceneToLoad = "Sample Scene";

    public TMP_Text mainText;

    // Start is called before the first frame update
    void Start()
    {
        _storyindex = 0;
    }

    public void NextLineofStory()
    {
        /*if(_storyindex++ > 0)
        {
            _storyindex++;
        }*/
        //_storyindex++;
        if (_storyindex < story.Length)
        {
            mainText.SetText(story[_storyindex]);
            _storyindex++;
        }
        else
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
