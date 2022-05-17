using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text mText;

    private int mScore;

    // Start is called before the first frame update
    void Start()
    {
        mText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScore(int value) 
    {
        mScore = mScore + value;
        mText.text = "Score: " + mScore;
    }
}
