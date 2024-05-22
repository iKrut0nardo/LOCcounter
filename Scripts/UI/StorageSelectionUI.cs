using GDE.GenericSelectionUI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageSelectionUI : SelectionUI<ImageSlot>
{
    [SerializeField] List<ImageSlot> boxSlots;

    private void Start()
    {
        SetItems(boxSlots);
        SetSelectionSettings(SelectionType.Grid, 6);
    }
}
