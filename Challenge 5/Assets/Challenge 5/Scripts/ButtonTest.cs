using UnityEngine;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour
{
    public Button testButton;

    void Start()
    {
        testButton.onClick.AddListener(() => Debug.Log("Button clicked!"));
    }
}
