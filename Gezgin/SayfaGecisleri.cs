using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class SayfaGecisleri : MonoBehaviour
{

    public void BaslangicSayfasi()
    {
        SceneManager.LoadScene("BaslangicSayfasi");
    }

    public void Anasayfa()
    {
        SceneManager.LoadScene("Anasayfa");
    }

    public void Istanbul()
    {
        SceneManager.LoadScene("Istanbul");
    }



}
