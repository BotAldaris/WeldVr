using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Quiz : MonoBehaviour
{
    private Dictionary<int, Question> quiz = new Dictionary<int, Question>
        {
            { 1, new Question {
                Pergunta = "Qual o tipo de g�s � comumente usado na solda MIG/MAG?",
                Opcoes = new List<string> { "a) Oxig�nio", "b) G�s Carb�nico (CO2)", "c) Nitrog�nio", "d) Hidrog�nio" },
                RespostaCorreta = 'b'
            }},
            {
    2, new Question
    {
        Pergunta = "Quais par�metros el�tricos devem ser ajustados para realizar a solda?",
        Opcoes = new List<string> { "a) Voltagem, amperagem e velocidade do arame", "b) Press�o do ar e temperatura ambiente", "c) Tamanho do eletrodo e dist�ncia da tocha", "d) Frequ�ncia e comprimento do arco" },
        RespostaCorreta = 'a'
    }},
            {
    3, new Question
    {
        Pergunta = "O que � o cabo obra?",
        Opcoes = new List<string> { "a) Cabo que alimenta o eletrodo de soldagem", "b) Cabo de aterramento da pe�a ou mesa", "c) Cabo de conex�o da fonte de solda � rede el�trica", "d) Cabo que ajusta a corrente de soldagem" },
        RespostaCorreta = 'b'
    }},
            {
    4, new Question
    {
        Pergunta = "Qual o tipo de luva que deve ser usado para soldar?",
        Opcoes = new List<string> { "a) Luva de tecido", "b) Luva de couro resistente ao calor", "c) Luva de l�tex", "d) Luva de borracha" },
        RespostaCorreta = 'b'
    }},
            {
    5, new Question
    {
        Pergunta = "Quais tipos de materiais podem ser soldados no processo MIG/MAG?",
        Opcoes = new List<string> { "a) Apenas a�o carbono", "b) Apenas metais n�o ferrosos", "c) A�o carbono, a�o inoxid�vel e alum�nio", "d) Apenas ligas met�licas" },
        RespostaCorreta = 'c'
    }},
            {
    6, new Question
    {
        Pergunta = "O que � a po�a de fus�o?",
        Opcoes = new List<string> { "a) Regi�o da pe�a aquecida pela chama da soldagem", "b) Ac�mulo de esc�ria durante a solda", "c) �rea fundida do material na zona de soldagem", "d) Fissura que surge ap�s o resfriamento da solda" },
        RespostaCorreta = 'c'
    }},
            {
    7, new Question
    {
        Pergunta = "Quais os principais riscos envolvidos na soldagem?",
        Opcoes = new List<string> { "a) Ru�do e desconforto visual", "b) Queimaduras, choques el�tricos e exposi��o a gases t�xicos", "c) Fadiga muscular e dor nas costas", "d) Falta de ilumina��o e dificuldade de vis�o" },
        RespostaCorreta = 'b'
    }},
            {
    8, new Question
    {
        Pergunta = "Qual a angula��o recomendada para a tocha, durante a soldagem?",
        Opcoes = new List<string> { "a) 10� a 20�", "b) 45� a 60�", "c) 90�", "d) 15� a 25�" },
        RespostaCorreta = 'd'
    }},
            {
    9, new Question
    {
        Pergunta = "Quais os passos iniciais para se iniciar a soldagem?",
        Opcoes = new List<string> { "a) Conectar a m�quina, ajustar os par�metros e posicionar a pe�a", "b) Ligar o ventilador, ajustar a ilumina��o e iniciar a soldagem", "c) Escolher o material de enchimento e pressionar o pedal", "d) Acender o ma�arico e aplicar a solda" },
        RespostaCorreta ='a'
    }},
            {
    10, new Question
    {
        Pergunta = "O que acontece se n�o conectar o cabo obra na mesa ou pe�a?",
        Opcoes = new List<string> { "a) A solda n�o ter� ader�ncia", "b) A pe�a se fundir� rapidamente", "c) A corrente el�trica n�o completar� o circuito e a solda n�o ocorrer�", "d) O arco ser� muito intenso e a pe�a poder� derreter" },
        RespostaCorreta = 'c'
    }},
            {
    11, new Question
    {
        Pergunta = "A sigla MIG refere-se a:",
        Opcoes = new List<string> { "a) Soldagem com arco manual", "b) Soldagem com g�s ativo", "c) Soldagem com g�s inerte", "d) Soldagem com eletrodo revestido" },
        RespostaCorreta = 'c'
    }},
            {
    12, new Question
    {
        Pergunta = "A sigla MAG refere-se a:",
        Opcoes = new List<string> { "a) Soldagem com arco protegido", "b) Soldagem com g�s inerte", "c) Soldagem com g�s ativo", "d) Soldagem com eletrodo de tungst�nio" },
        RespostaCorreta = 'c'
    }},
            {
    13, new Question
    {
        Pergunta = "Qual a fun��o do g�s na soldagem?",
        Opcoes = new List<string> { "a) Resfriar o arco el�trico", "b) Proteger a po�a de fus�o contra contamina��o do ar", "c) Aumentar a temperatura do arco el�trico", "d) Eliminar impurezas da solda" },
        RespostaCorreta = 'b'
    }},
            {
    14, new Question
    {
        Pergunta = "Qual a import�ncia do uso de equipamentos de prote��o individual (EPIs) durante a soldagem?",
        Opcoes = new List<string> { "a) Apenas para evitar pequenos desconfortos", "b) Para proteger o soldador contra queimaduras, choques el�tricos e inala��o de gases t�xicos", "c) Para reduzir o risco de danos ao equipamento de soldagem", "d) Para melhorar a precis�o do trabalho" },
        RespostaCorreta = 'b'
    }},
            {
    15, new Question
    {
        Pergunta = "O que pode causar a falta de penetra��o na solda?",
        Opcoes = new List<string> { "a) Alta corrente el�trica e velocidade de soldagem baixa", "b) Corrente el�trica muito baixa ou velocidade de soldagem muito alta", "c) Uso de g�s incorreto", "d) Excesso de calor durante o processo" },
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
                correto.text = "Parab�ns, voc� acertou.";
            }
            else
            {
                correto.text = "N�o foi dessa vez.";
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
