using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefsSave :  MonoBehaviour
{
    public string gameSceneName; //Nome da cena de jogo
    public string playerObjetctName; // Nome do objeto do Player na cena de jogo

    public void SavePosition(Transform player)
    {
        PlayerPrefs.SetFloat("PlayerX", player.position.x);
        PlayerPrefs.SetFloat("PlayerY", player.position.y);
        PlayerPrefs.SetFloat("PlayerZ", player.position.z);
        PlayerPrefs.Save();
        Debug.Log("Posição salva!");
        
    }

    public void LoadPositionAndScene()
    {
        SceneManager.sceneLoaded += OnGameSceneLoaded;
        SceneManager.LoadScene(gameSceneName);
    }
    private void OnGameSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        GameObjetct player = GameObject.Find(playerObjetctName);
        if (player == null) 
        {
            float x = PlayerPrefs.GetFloat("PlayerX", 0);
            float y = PlayerPrefs.GetFloat("PlayerY", 0);
            float z = PlayerPrefs.GetFloat("Playerz", 0);

            player.transform.position = new Vector3(x, y, z);
            Debug.Log("position carregada!");
        
        }
        else
        {
            Debug.LogWarning("Player não encontrado na cena!");


        }
        SceneManager.sceneLoaded -= OnGameSceneLoaded;

    }




}




