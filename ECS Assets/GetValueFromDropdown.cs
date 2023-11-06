using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetValueFromDropdown : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public int difficulty;

    public void getDropdownValue()
    {
        difficulty = dropdown.value;
    }
}
