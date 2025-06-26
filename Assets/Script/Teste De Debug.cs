using UnityEngine;

public class TesteDeDebug : MonoBehaviour
{
    [Header("Atributos do Jogador")]
    [Tooltip("Vida inicial do jogador")]
    [Range(0, 100)]
    public int vida = 100;

    [SerializeField]
    [Tooltip("Referência ao inimigo encontrado na cena")]
    private GameObject inimigo;

    void Start()
    {
        Debug.Log("🟢 Iniciando sistema de debug...");

        // Busca por um objeto chamado "Inimigo" na cena
        inimigo = GameObject.Find("Inimigo");

        // Checa a condição de vida crítica
        if (vida < 50)
        {
            Debug.LogWarning("⚠️ Atenção: Vida do jogador está abaixo de 50!");
        }

        // Checa se o inimigo foi localizado com sucesso
        if (inimigo is null)
        {
            Debug.LogError("❌ Erro: Inimigo não encontrado na cena!");
        }
        else
        {
            Debug.Log($"✅ Inimigo encontrado: {inimigo.name}");
        }
    }
}
