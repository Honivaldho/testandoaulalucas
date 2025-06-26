using UnityEngine;
using TMPro;

public class TesteUI : MonoBehaviour
{
    public GameObject alvo;
    public TMP_Text texto;
    public TMP_Dropdown corDropdown;
    public TMP_InputField campoTexto;
    public float fatorEscala = 1.1f;

    public void ToggleAtivo(GameObject obj)
    {
        obj.SetActive(!obj.activeSelf);
    }
    public void Aumentar()
    {
        alvo.transform.localScale *= fatorEscala;
    }
    public void Diminuir()
    {
        alvo.transform.localScale /= fatorEscala;
    }
    public void MudarCor()
    {
        Color cor = Color.white;

        switch (corDropdown.value)
        {
            case 0: cor = Color.red; break;
            case 1: cor = Color.green; break;
            case 2: cor = Color.blue; break;
            case 3: cor = Color.yellow; break;
        }

        if (alvo.TryGetComponent<Renderer>(out var rend)) rend.material.color = cor;
    }
    public void AtualizarTexto()
    {
        texto.text = campoTexto.text;
    }
}