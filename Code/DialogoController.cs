using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoController : MonoBehaviour
{
    public GameObject PanelDialogo;
    public Text falaNPC;
    public GameObject respostas;

    private bool falaAtiva = false;

    FalaNPC falas;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && falaAtiva) {
            if (falas.resposta.Length > 0)
            {
                MostrarRespostas();

            }
            else
            {
                falaAtiva = false;
                PanelDialogo.SetActive(false);
                falaNPC.gameObject.SetActive(false);
                FindObjectOfType<Jogador>().speed = 2;
            }
        
        }
    }
    void MostrarRespostas() {
        falaNPC.gameObject.SetActive(false);
        falaAtiva = false;

        for (int i = 0; i < falas.resposta.Length; i++) {
            GameObject tempResposta = Instantiate(respostas, PanelDialogo.transform) as GameObject;
            tempResposta.GetComponent<Text>().text = falas.resposta[i].resposta;
            tempResposta.GetComponent<BotaoResposta>().Setup(falas.resposta[i]);
        }
    }
    public void ProximaFala(FalaNPC fala) {
        falas = fala;
        falaAtiva = true;
        PanelDialogo.SetActive(true);
        falaNPC.gameObject.SetActive(true);

        falaNPC.text = falas.fala;
    }
    void LimparResposta() {
        BotaoResposta[] buttons = FindObjectsOfType<BotaoResposta>();
        foreach (BotaoResposta button in buttons) {
            Destroy(button.gameObject);
        }
    }
}
