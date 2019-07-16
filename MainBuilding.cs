using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MainBuilding : MonoBehaviour {
    public int level = 1, coins = 500, xp = 0;
    public TextMesh t;

    public void Start() {
        GameObject text = new GameObject();
        t = text.AddComponent<TextMesh>();
    }


    public void OnMouseDown() {
        t.text = "Level: " + level.ToString() + "\nCoins: " + coins.ToString() + "\nXP: " + xp.ToString() + "/" + (level * level * 10).ToString();
        //t.fontSize = 30;
        t.transform.localPosition += new Vector3(-15f, 10f, -5);
        //print("Level: " + level + "\nCoins: " + coins + "\nXP: " + xp + "/" + (level * level * 10));
    }
}
