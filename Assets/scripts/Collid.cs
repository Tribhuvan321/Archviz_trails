using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collid : MonoBehaviour
{
    private GameObject[] walls;
    private float length;
    private float breath;
    private float height;
    private float volume;
    private float basePrice;
    private float pricePerCube = 1;
    public TextMeshProUGUI basePriceText;
    // Start is called before the first frame update
    void Start()
    {
        walls = GameObject.FindGameObjectsWithTag("Wall");
        for (int i = 0; i < walls.Length; i++)
        {
            walls[i].AddComponent<BoxCollider>();
            length = walls[i].GetComponent<BoxCollider>().size.x;
            breath = walls[i].GetComponent<BoxCollider>().size.y;
            height = walls[i].GetComponent<BoxCollider>().size.z;
            volume += length * breath * height;
        }
        basePrice = volume * pricePerCube;
        basePriceText.text = "Base Price: " + basePrice;

    }

    // Update is called once per frame
    void Update()
    {

    }
}