using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        coinCountText.text = "Coins: " + CombineInstance.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateCoinCount()
    {
        coins++;

    }
}
