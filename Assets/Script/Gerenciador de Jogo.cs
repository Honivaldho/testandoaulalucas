using UnityEngine;

public class GerenciadorDeJogo : MonoBehaviour
{
    public int vidas = 3;
    private int pontuacao = 0;
    private GameObject jogador;

    void Start()
    {
        jogador = GameObject.Find("Jogador");

        if (jogador == null)
        {
            Debug.LogError("❌ Jogador não encontrado");
        }
        else
        {
            Debug.Log("🟢 Jogo iniciado com " + vidas + " vidas.");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReiniciarJogo();
        }
    }

    void ReiniciarJogo()
    {
        vidas = 3;
        pontuacao = 0;
        Debug.Log("🔄 Jogo reiniciado");
    }
}
