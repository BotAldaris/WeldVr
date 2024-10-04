using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Quiz : MonoBehaviour
{
    private Dictionary<int, Question> quiz = new Dictionary<int, Question>
        {
            { 1, new Question {
                Pergunta = "Qual o tipo de gás é comumente usado na solda MIG/MAG?",
                Opcoes = new List<string> { "a) Oxigênio", "b) Gás Carbônico (CO2)", "c) Nitrogênio", "d) Hidrogênio" },
                RespostaCorreta = 'b'
            }},
            {
    2, new Question
    {
        Pergunta = "Quais parâmetros elétricos devem ser ajustados para realizar a solda?",
        Opcoes = new List<string> { "a) Voltagem, amperagem e velocidade do arame", "b) Pressão do ar e temperatura ambiente", "c) Tamanho do eletrodo e distância da tocha", "d) Frequência e comprimento do arco" },
        RespostaCorreta = 'a'
    }},
            {
    3, new Question
    {
        Pergunta = "O que é o cabo obra?",
        Opcoes = new List<string> { "a) Cabo que alimenta o eletrodo de soldagem", "b) Cabo de aterramento da peça ou mesa", "c) Cabo de conexão da fonte de solda à rede elétrica", "d) Cabo que ajusta a corrente de soldagem" },
        RespostaCorreta = 'b'
    }},
            {
    4, new Question
    {
        Pergunta = "Qual o tipo de luva que deve ser usado para soldar?",
        Opcoes = new List<string> { "a) Luva de tecido", "b) Luva de couro resistente ao calor", "c) Luva de látex", "d) Luva de borracha" },
        RespostaCorreta = 'b'
    }},
            {
    5, new Question
    {
        Pergunta = "Quais tipos de materiais podem ser soldados no processo MIG/MAG?",
        Opcoes = new List<string> { "a) Apenas aço carbono", "b) Apenas metais não ferrosos", "c) Aço carbono, aço inoxidável e alumínio", "d) Apenas ligas metálicas" },
        RespostaCorreta = 'c'
    }},
            {
    6, new Question
    {
        Pergunta = "O que é a poça de fusão?",
        Opcoes = new List<string> { "a) Região da peça aquecida pela chama da soldagem", "b) Acúmulo de escória durante a solda", "c) Área fundida do material na zona de soldagem", "d) Fissura que surge após o resfriamento da solda" },
        RespostaCorreta = 'c'
    }},
            {
    7, new Question
    {
        Pergunta = "Quais os principais riscos envolvidos na soldagem?",
        Opcoes = new List<string> { "a) Ruído e desconforto visual", "b) Queimaduras, choques elétricos e exposição a gases tóxicos", "c) Fadiga muscular e dor nas costas", "d) Falta de iluminação e dificuldade de visão" },
        RespostaCorreta = 'b'
    }},
            {
    8, new Question
    {
        Pergunta = "Qual a angulação recomendada para a tocha, durante a soldagem?",
        Opcoes = new List<string> { "a) 10º a 20º", "b) 45º a 60º", "c) 90º", "d) 15º a 25º" },
        RespostaCorreta = 'd'
    }},
            {
    9, new Question
    {
        Pergunta = "Quais os passos iniciais para se iniciar a soldagem?",
        Opcoes = new List<string> { "a) Conectar a máquina, ajustar os parâmetros e posicionar a peça", "b) Ligar o ventilador, ajustar a iluminação e iniciar a soldagem", "c) Escolher o material de enchimento e pressionar o pedal", "d) Acender o maçarico e aplicar a solda" },
        RespostaCorreta ='a'
    }},
            {
    10, new Question
    {
        Pergunta = "O que acontece se não conectar o cabo obra na mesa ou peça?",
        Opcoes = new List<string> { "a) A solda não terá aderência", "b) A peça se fundirá rapidamente", "c) A corrente elétrica não completará o circuito e a solda não ocorrerá", "d) O arco será muito intenso e a peça poderá derreter" },
        RespostaCorreta = 'c'
    }},
            {
    11, new Question
    {
        Pergunta = "A sigla MIG refere-se a:",
        Opcoes = new List<string> { "a) Soldagem com arco manual", "b) Soldagem com gás ativo", "c) Soldagem com gás inerte", "d) Soldagem com eletrodo revestido" },
        RespostaCorreta = 'c'
    }},
            {
    12, new Question
    {
        Pergunta = "A sigla MAG refere-se a:",
        Opcoes = new List<string> { "a) Soldagem com arco protegido", "b) Soldagem com gás inerte", "c) Soldagem com gás ativo", "d) Soldagem com eletrodo de tungstênio" },
        RespostaCorreta = 'c'
    }},
            {
    13, new Question
    {
        Pergunta = "Qual a função do gás na soldagem?",
        Opcoes = new List<string> { "a) Resfriar o arco elétrico", "b) Proteger a poça de fusão contra contaminação do ar", "c) Aumentar a temperatura do arco elétrico", "d) Eliminar impurezas da solda" },
        RespostaCorreta = 'b'
    }},
            {
    14, new Question
    {
        Pergunta = "Qual a importância do uso de equipamentos de proteção individual (EPIs) durante a soldagem?",
        Opcoes = new List<string> { "a) Apenas para evitar pequenos desconfortos", "b) Para proteger o soldador contra queimaduras, choques elétricos e inalação de gases tóxicos", "c) Para reduzir o risco de danos ao equipamento de soldagem", "d) Para melhorar a precisão do trabalho" },
        RespostaCorreta = 'b'
    }},
            {
    15, new Question
    {
        Pergunta = "O que pode causar a falta de penetração na solda?",
        Opcoes = new List<string> { "a) Alta corrente elétrica e velocidade de soldagem baixa", "b) Corrente elétrica muito baixa ou velocidade de soldagem muito alta", "c) Uso de gás incorreto", "d) Excesso de calor durante o processo" },
        RespostaCorreta = 'b'
    }}
        };
    private Dictionary<char, int> letrasValores = new Dictionary<char, int>()
        {
            { 'a', 0 },
            { 'b', 1 },
            { 'c', 2 },
            { 'd', 3 }
        };
    public TextMeshProUGUI[] alternativas;
    public TextMeshProUGUI titulo;
    public TextMeshProUGUI correto;
    public TextMeshProUGUI resposta;
    public TextMeshProUGUI botao;
    public GameObject alternativa;
    public GameObject questao;
    public GameObject resp;

    char alternativaSelecionada = 'a';
    int indexAlternativa = 1;
    private bool confirmar = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateAlternatva();
    }
    public void SetAlternativaSelecionada(char alternativa)
    {
        alternativaSelecionada = alternativa;
    }
    public void SetAlternativaSelecionada(string alternativa)
    {
        alternativaSelecionada = alternativa[0];
    }
    void UpdateAlternatva()
    {
        var question = quiz[indexAlternativa];
        titulo.text = question.Pergunta;
        for (int i = 0; i < alternativas.Length; i++)
        {
            alternativas[i].text = question.Opcoes[i];
        }
    }
    public void ConfirmarProximo()
    {
        if (confirmar)
        {
            questao.SetActive(false);
            resp.SetActive(true);
            if (quiz[indexAlternativa].RespostaCorreta == alternativaSelecionada)
            {
                correto.text = "Parabéns, você acertou.";
            }
            else
            {
                correto.text = "Não foi dessa vez.";
            }
            resposta.text = "Resposta correta\n" + quiz[indexAlternativa].Opcoes[letrasValores[quiz[indexAlternativa].RespostaCorreta]];
            alternativa.gameObject.SetActive(false);
            correto.gameObject.SetActive(true);
            resposta.gameObject.SetActive(true);
            botao.text = "Proximo";
            confirmar = false;
        }
        else
        {
            questao.SetActive(true);
            resp.SetActive(false);
            indexAlternativa++;
            UpdateAlternatva();
            correto.gameObject.SetActive(false);
            resposta.gameObject.SetActive(false);
            alternativa.gameObject.SetActive(true);
            botao.text = "Confirmar";
            confirmar = true;
        }
    }

}
