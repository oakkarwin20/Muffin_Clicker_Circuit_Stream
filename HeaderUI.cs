using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HeaderUI : MonoBehaviour
{
    //UI
    [SerializeField] private TMP_Text muffinsText  = null;
    [SerializeField] private TMP_Text muffinsPerSecondText = null;
    private int muffinsPerSecond;

    public void UpdateUI(int totalClicks, int pointsPerSecond)
    {
          if (totalClicks == 1)
          {
              muffinsText.text = totalClicks.ToString() + " muffin";
              Debug.Log($"Muffin was Clicked {totalClicks} time");
          }

          else
          {
              muffinsText.text = totalClicks.ToString() + " muffins";
              Debug.Log($"Muffin was Clicked {totalClicks} times");
          }

          if (muffinsPerSecond == 1)
          {
            muffinsPerSecondText.text = muffinsPerSecond.ToString() + " muffin per second";
              Debug.Log($"Muffin was Clicked {muffinsPerSecond} time");
          }

          else
          {
            muffinsPerSecondText.text = muffinsPerSecond.ToString() + " muffins per second";
              Debug.Log($"Muffin was Clicked {muffinsPerSecond} times");
          }
    }
}
