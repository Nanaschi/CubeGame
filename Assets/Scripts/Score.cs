using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform playerZPosition;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = playerZPosition.position.z.ToString("0");
    }
}
