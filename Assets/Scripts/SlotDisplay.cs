
using UnityEngine;
using UnityEngine.UI;

public class SlotDisplay : MonoBehaviour
{
    private Image myImage;

    private void OnEnable()
    {
        myImage = GetComponent<Image>();
    }

    public void SetSlot(Slot slot)
    {
        myImage.color = slot.Color;
    }
}