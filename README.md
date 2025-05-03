# STUDENT

**STUDENT** é uma plataforma web de compartilhamento de conteúdos acadêmicos entre estudantes. Permite que os usuários publiquem materiais como resumos, links, vídeos e PDFs, com organização por disciplina, comentários, curtidas e favoritos.

---

## ✨ Funcionalidades Principais

- ✅ Cadastro e login com autenticação JWT
- 📚 Upload de arquivos e links educacionais
- 🗂 Organização de conteúdos por disciplinas
- 🔍 Pesquisa por título, descrição ou autor
- 💬 Comentários e curtidas em conteúdos
- ⭐ Favoritos e listagem personalizada
- 👤 Perfil de usuário com histórico de postagens

---

## 🚀 Tecnologias Utilizadas

- **Backend**: ASP.NET Core, EF Core, SQL Server
- **Frontend**: React.js, Vite, TailwindCSS
- **Testes**: xUnit, Moq, FluentAssertions
- **Infraestrutura**: Docker, JWT, Swagger
- **CI/CD**: GitHub Actions

---

## 📁 Estrutura do Projeto
```bash
STUDENT/
│
├── .github/                        # Configurações de CI/CD com GitHub Actions
│   ├── workflows/
│   │   └── (ex: domainCI.yml)      # Arquivos de automação para build/teste
│   │    
│   └── workflows.md                #Explica os fluxos automatizados (CI/CD)  
│
├── .vscode/                        # Configs de ambiente para o VSCode (ex: launch.json, settings.json)
│
├── doc/                            # Documentação geral do projeto
│   ├── blueprint/                  # Documentação técnica e de requisitos
│   │   ├── ProjectOverview.md      # Visão geral, objetivos, funcionalidades e futuras melhorias
│   │   ├── RN-RF-RNF.md            # Regras de negócio, requisitos funcionais e não funcionais
│   │   └── Setup.md                # Guia de instalação e uso local (manual do dev)
│   └── visual/                     # Diagramas, wireframes, fluxogramas etc. (a adicionar)
│
├── src/                            # Código-fonte principal
│   ├── backend/                    # Projeto ASP.NET Core (API REST)
│   │   ├── Student.Application/    # Casos de uso e lógica de aplicação
│   │   ├── Student.Domain/         # Entidades e regras de domínio
│   │   ├── Student.Infrastructure/ # Persistência, repositórios, external services
│   │   ├── Student.Presentation/   # Controllers e configurações de API
│   │   └── backend.md              # Documentação explicando a arquitetura e libs usadas
│   │
│   ├── frontend/                   # Projeto React com Vite
│   │   ├── student.web/            # Código do frontend (componentes, páginas, serviços)
│   │   └── frontend.md             # Explicação da stack e organização do frontend
│
├── test/                           # Testes automatizados
│   └── Student.UnitTest/           # Testes unitários com xUnit
│       └── test.md                 # Explicação dos testes, bibliotecas e estrutura
│
├── .gitattributes                  # Define atributos de arquivos para Git (ex: fim de linha, linguagens)
├── .gitignore                      # Ignora arquivos/diretórios (ex: bin/, obj/, node_modules/)
├── LICENSE                         # Licença de uso do projeto (MIT, permissiva)
├── README.md                       # Introdução ao projeto, funcionalidades, estrutura e como rodar
└── Student.sln                     # Arquivo de solução do Visual Studio (.NET)
