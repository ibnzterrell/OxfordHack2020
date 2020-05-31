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

    public InputField userfield;
    public echoARHandler echoARInstance;
    public Dropdown dropdown;

    // Start is called before the first frame update
    void Start()
    {
        scanButton.onClick.AddListener(scanClick);
        loginButton.onClick.AddListener(loginClick);
        placeButton.onClick.AddListener(placeClick);

        List<string> options = new List<string>();
        options.Add("log_stackLarge.glb");
        options.Add("tent_detailedOpen.glb");
        options.Add("canoe.glb");
        dropdown.ClearOptions();
        dropdown.AddOptions(options);
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
        Debug.Log("Login pressed");
        echoARInstance.user = userfield.text;
        echoARInstance.load();
    }

    void placeClick()
    {
        echoARInstance.setModel(userfield.text, dropdown.options[dropdown.value].text);
    }

    public void updateTarget(string name)
    {
        targetLabel.text = name;
    }
}
