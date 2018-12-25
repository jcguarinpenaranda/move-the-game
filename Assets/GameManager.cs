using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public int points = 0;
    public Text pointsText;
    private int totalPoints = 0;

	// Use this for initialization
	void Start () {
        GameObject[] pointObjects = GameObject.FindGameObjectsWithTag("Point");
        totalPoints = pointObjects.Length;

        UpdatePointsText();
    }
	
	// Update is called once per frame
	void Update () {
	}

    void UpdatePointsText()
    {
        pointsText.text = points + " / " + totalPoints;
    }

    public void AddPoints(int qty)
    {
        points += qty;
        UpdatePointsText();

    }
}
