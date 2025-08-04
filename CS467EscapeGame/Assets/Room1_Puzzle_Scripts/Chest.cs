// Author: Larisa Xie
// Class: CS467 Summer 2025
// Date: 8/3/25
// Description: Toggles treasure chest to open/close.

using UnityEngine;

public class Chest : MonoBehaviour
{
    public GameObject openLid;
    public GameObject closeLid;

    public void ToggleChest()
    {
        if (closeLid.activeSelf)
        {
            openLid.SetActive(true);
            closeLid.SetActive(false);
        }

        else
        {
            openLid.SetActive(false);
            closeLid.SetActive(true);
        }
    }

}
