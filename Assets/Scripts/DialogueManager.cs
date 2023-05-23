using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [Header("Dialogue UI")]
    [SerializeField] public GameObject dialoguePanel;
    [SerializeField] public Text dialogueText;
    private static DialogueManager instance;
    private Story currentStory;
    private bool dialogueIsPlaying;
    public int missaoAtiva;
    public Text missao;
    public Text nome;
    
        // Nome de cada personagem
    private string[] nomes = new string[]{"EDUARDO", "ANA", "RICK", "BLOB", "JOAO DA SILVA", "WILL", "JOHN", "PROFETA", "BELLY", "FRED", "OFICIAL"};
    // Missoes
    private string[] missoes = new string[]{"Interdimensional Troubles", "1- Ir falar com o Rick", "1.1- Falar com o Blob", 
        "1.2- Entregar o C.O.C.O para o Joao Silva", "2- Falar com o Will", "3- De a carta ao Jhon", "4- Fale com o ~Profeta~", "4.1 Entregue o ~Iogurte~ para a Belly",
        "5- fale com a Junny", "6- Fale de novo com o Blob" ,"6.1- Fale com o Fred", "6.2- Va ate a delegacia", "6.3- Fale mais uma vez com o Blob", "7- Fale com o Fred",
        "7.1- Ache os 5 gatinhos", "7.2- fale com o Fred", "8- Compre a janta", "8.1- Leve a janta ate sua casa", "Fim do Dia"};

    // Start is called before the first frame update
    private void Awake() {
        instance = this;
    }

    void Start()
    {
        dialogueIsPlaying = true;
        missaoAtiva = 0;
    }

    // Update is called once per frame
    void Update()
    {
        missao.text = missoes[missaoAtiva];
    }

    public static DialogueManager GetInstance(){
        return instance;
    }
}
