using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalPoints : MonoBehaviour
{
    [SerializeField]
    private TMPro.TextMeshProUGUI textPoints;

    private void Start()
    {
        textPoints.text = PlayerPrefs.GetInt("POINTS").ToString();
    }
}
