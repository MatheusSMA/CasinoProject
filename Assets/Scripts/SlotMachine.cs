using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;


public class SlotMachine : MonoBehaviour
{
    public int num1, num2, num3;
    public SlotDisplay row1, row2, row3;
    public List<Slot> slots = new List<Slot>();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SortRow();
        }
    }

    private void SortRow()
    {
        System.Random rand = new System.Random();
        num1 = rand.Next(1, 100);
        // num2 = rand.Next(1, 100);
        // num3 = rand.Next(1, 100);

        Slot rightSlot = slots.FirstOrDefault(item => item.Chance >= num1);
        row1.SetSlot(rightSlot);


    }


}

