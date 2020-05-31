using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public CloudRecoEventHandler cloudReco;

    public Text targetLabel;
    public Button scanButton;
    public Button loginButton;
    public Button placeButton;
    // Start is called before the first frame update
    void Start()
    {
        scanButton.onClick.AddListener(scanClick);
        loginButton.onClick.AddListener(loginClick);
        placeButton.onClick.AddListener(placeClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void scanClick()
    {
        cloudReco.startScanning();
    }

    void loginClick()
    {

    }

    void placeClick()
    {

    }

    public void updateTarget(string name)
    {
        targetLabel.text = name;
    }
}
