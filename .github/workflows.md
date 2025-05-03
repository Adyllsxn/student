# 📦 GitHub Actions – Workflows

Este diretório contém os **workflows de automação** do projeto STUDENT, utilizando **GitHub Actions**. Os workflows permitem executar tarefas automáticas a cada push, pull request ou outro evento definido no repositório.

---

## 🎯 Objetivo

Os workflows servem para:

- 🔁 Executar testes automatizados
- 🧱 Garantir que o projeto compila corretamente
- ✅ Validar PRs com qualidade de código
- 📦 Preparar para deploy (em etapas futuras)
- 🚨 Aumentar a confiabilidade do código

---

## 📁 Estrutura dos Workflows

```bash
.github/
└── workflows/
    ├── applicationCI.md    
    ├── domainCI.yml        
    ├── infrastructureCI.yml          
    ├── presentation.yml
    └── testUnityCI.yml       
