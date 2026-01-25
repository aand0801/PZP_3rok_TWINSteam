using UnityEngine;
using TMPro;

public class TriggerMessage : MonoBehaviour
{
    [TextArea]
    public string message;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            TextMeshPro text = other.GetComponentInChildren<TextMeshPro>();

            if (text != null)
            {
                text.text = message;
                Invoke(nameof(ClearText), 3f);
            }
        }
    }

    void ClearText()
    {
        TextMeshPro text = FindAnyObjectByType<TextMeshPro>();
        if (text != null)
            text.text = "";
    }
}
