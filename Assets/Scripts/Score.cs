using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{

    public Transform player;
    public TextMeshProUGUI score;

    // Update is called once per frame
    void Update()
    {
        score.text = player.transform.position.z.ToString("0");
    }
}
