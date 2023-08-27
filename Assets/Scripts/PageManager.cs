using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageManager : MonoBehaviour
{
    public GameObject[] pages;
    private int currentPageIndex = 0; 

    public enum E_page
    {
        Home = 0,
        Home_Game1 = 1,
        Home_Game2 = 2,
        Home_Game3 = 3,
        Home_Game4 = 4,
        Home_Game5 = 5,
        Home_Random_Game = 6,
        Home_Mix_Game = 7,
        User = 8,
        Param = 9,
    }

    private void Start()
    {
        SwitchPage(currentPageIndex);
    }

    private void ShowNextPage()
    {
        currentPageIndex = (currentPageIndex + 1) % pages.Length;
        SwitchPage(currentPageIndex);
    }

    private void ShowPreviousPage()
    {
        currentPageIndex = (currentPageIndex - 1 + pages.Length) % pages.Length;
        SwitchPage(currentPageIndex);
    }

    public void SwitchPage(int pageIndex)
    {
        for (int i = 0; i < pages.Length; i++)
        {  
            // Pour chaque page, met false en setactive si ce n'est pas la page ciblé, et true si ça l'est.
            pages[i].SetActive(i == pageIndex);
        }
    }

    public void ShowPage(int pageIndex)
    {
        for (int i = 0; i < pages.Length; i++)
        {
            if (i == pageIndex)
                pages[i].SetActive(true);
        }
    }

    private void ShowPage(GameObject page)
    {
        page.SetActive(true);
    }
}
