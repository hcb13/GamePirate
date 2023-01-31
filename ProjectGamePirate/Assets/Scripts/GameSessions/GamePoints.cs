using UnityEngine;

public class GamePoints : MonoBehaviour
{
    [SerializeField]
    private TMPro.TextMeshProUGUI textPoints;

    private int points;

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        UpdatePoints();
    }

    public void IncreasePoints()
    {
        points += 1;
        UpdatePoints();
    }

    private void UpdatePoints()
    {
        textPoints.text = points.ToString();
        PlayerPrefs.SetInt("POINTS", points);
    }
}
