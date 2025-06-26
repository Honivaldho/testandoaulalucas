using UnityEngine;

public class ContadorDePontos : MonoBehaviour
{
    private int pontos;

    void Start()
    {
        pontos = 0;
        Debug.Log("🟢 Jogo Iniciado");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pontos += 1;
            Debug.Log("Pontos atuais: " + pontos);
        }
    }
}
