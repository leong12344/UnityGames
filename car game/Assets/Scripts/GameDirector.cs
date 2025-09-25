using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject Distance;

    // Start is called before the first frame update
    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.Distance = GameObject.Find("Distance");
        
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        this.Distance.GetComponent<TextMeshProUGUI>().text = "Distance:" + length.ToString("F2") + "m";
    }
}
