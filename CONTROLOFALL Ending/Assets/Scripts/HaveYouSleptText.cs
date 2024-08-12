using TMPro;
using UnityEngine;

public class HaveYouSleptText : MonoBehaviour
{
    private TextMeshProUGUI tmp;
    private string text = "";
    // Start is called before the first frame update
    void Start()
    {
        tmp = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        text += "Have you slept? ";
        tmp.text = text;
    }
}
