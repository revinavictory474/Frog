using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static FrogGame.FrogTriggerZone;

public class OutputScore : MonoBehaviour
{
    internal static OutputScore outputScore;

    [SerializeField] internal Text textScore;

    private void Awake()

    {
        if (outputScore == null)
            outputScore = this;
        else Destroy(gameObject);
    }

    void Update()
    {
        TextScoreOutput();
    }

    private void TextScoreOutput()
    {
        textScore.text = frogTriggerZone._countHits.ToString();
    }
}
