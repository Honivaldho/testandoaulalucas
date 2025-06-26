using System.Collections;
using UnityEngine;

public class Temporizadores : MonoBehaviour
{
    public GameObject prefab;
    private bool podeSpawnar;
    public float tempo;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.K) && podeSpawnar)
        {
            StartCoroutine(Timer(5f));
        }

        if (Input.GetKeyDown(KeyCode.J) && podeSpawnar)
        {
            podeSpawnar = false;
            Instantiate(prefab, transform.position, Quaternion.identity);
            Invoke("Timer2", 5f);
        }

        if (!podeSpawnar)
        {
            tempo += Time.deltaTime;

            if (tempo >= 2f)
            {
                podeSpawnar = true;
                tempo = 0f;
            }
        }
        if (Input.GetKeyDown(KeyCode.L) && podeSpawnar)
        {
            podeSpawnar = false;
            Instantiate(prefab, transform.position, Quaternion.identity);
        }

    }
    public IEnumerator Timer(float segundos)
    {
        podeSpawnar = false;
        yield return new WaitForSeconds(segundos);
        Instantiate(prefab, transform.position, Quaternion.identity);
        podeSpawnar = true;
    }
    public void Timer2()
    {
        podeSpawnar = true;
    }
}