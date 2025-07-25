using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeColor : MonoBehaviour
{
    public Button btnColor;
    public Material targetMaterial;
    // Start is called before the first frame update
    void Start()
    {
        btnColor.onClick.AddListener(RandomColor);

    }
    public void RandomColor()
    {
        targetMaterial.color = new Color(Random.value, Random.value, Random.value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
