using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace FrogGame
{
    public class SettingsButton : MonoBehaviour
    {
        [SerializeField] private GameObject SettingsMenu;
        [SerializeField] private GameObject ButtonSettings;

        public void OpenSettingsMenu()
        {
            SettingsMenu.SetActive(true);
            ButtonSettings.SetActive(false);
        }

        public void CloseSettingsMenu()
        {
            SettingsMenu.SetActive(false);
            ButtonSettings.SetActive(true);

        }
    }
}