using UnityEngine;
using UnityEngine.SceneManagement;

public class GC : MonoBehaviour
{

    public string cenas;

    public void TrocarCena()
    {
        SceneManager.LoadScene(cenas);
        //SceneManager.LoadScene(0);
        //SceneManager.LoadScene("EM Jogo");
    }
    public void SairJogo()
    {
        Application.Quit(); //Fecha o aplicativo!
    }

}
