using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class ChangeLanguague : MonoBehaviour
{

    int currentLanguage = 0;

    private void Start()
    {
        UnityEngine.Localization.Locale searcher = LocalizationSettings.AvailableLocales.Locales[currentLanguage];
        //LocalizationSettings.SelectedLocale; idioma seleccionado
        while (LocalizationSettings.SelectedLocale != searcher && currentLanguage < LocalizationSettings.AvailableLocales.Locales.Count)
        {
            currentLanguage++;
            searcher = LocalizationSettings.AvailableLocales.Locales[currentLanguage];
        }
    }

    public void NextLanguage()
    {
        currentLanguage++;

        if (currentLanguage > LocalizationSettings.AvailableLocales.Locales.Count - 1)
        {
            currentLanguage = 0;
        }

        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[currentLanguage];
    }

    public void PrevLanguage()
    {
        currentLanguage--;

        if (currentLanguage < 0)
        {
            currentLanguage = LocalizationSettings.AvailableLocales.Locales.Count - 1;
        }

        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[currentLanguage];
    }
}
