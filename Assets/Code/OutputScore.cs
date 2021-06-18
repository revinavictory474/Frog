using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static FrogGame.FrogTriggerZone;

public class OutputScore : MonoBehaviour
{
    public static OutputScore outputScore;
    public Text textScore;

    private void Awake()
    {
        if (outputScore == null)
            outputScore = this;
        else Destroy(gameObject);
    }

    void Update()
    {
        textScore.text = frogTriggerZone._countHits.ToString();
        
    }
}
