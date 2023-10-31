
using UnityEngine;
using UnityEngine.UI;

public class SlotDisplay : MonoBehaviour
{
    private Image _myImage;

    private void OnEnable()
    {
        _myImage = GetComponent<Image>();
    }

    public void SetSlot(Slot slot)
    {
        _myImage.color = slot.Color;
    }
}