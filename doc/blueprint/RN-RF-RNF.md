# Regras de Negócio, Requisitos Funcionais e Não Funcionais – STUDENT

## 🧠 Regras de Negócio (RN)

- **RN01**: Apenas usuários autenticados podem realizar uploads de conteúdo.
- **RN02**: Cada conteúdo deve estar vinculado a um autor (usuário).
- **RN03**: O conteúdo deve ser categorizado por disciplina ou área de estudo.
- **RN04**: Comentários e curtidas são permitidos apenas a usuários autenticados.
- **RN05**: O autor pode editar ou remover o conteúdo postado.
- **RN06**: O sistema deve impedir o upload de arquivos maliciosos ou perigosos.

---

## ✅ Requisitos Funcionais (RF)

- **RF01**: O sistema deve permitir o cadastro e login de usuários.
- **RF02**: O sistema deve permitir o envio de arquivos e links.
- **RF03**: O usuário pode buscar conteúdos por palavras-chave, categoria ou autor.
- **RF04**: O sistema deve permitir comentários em conteúdos.
- **RF05**: O sistema deve disponibilizar o número de curtidas por conteúdo.
- **RF06**: O usuário pode editar ou excluir conteúdos que ele mesmo publicou.
- **RF07**: O sistema deve permitir salvar conteúdos favoritos.
- **RF08**: O sistema deve exibir os conteúdos mais populares.

---

## ❌ Requisitos Não Funcionais (RNF)

- **RNF01**: A aplicação deve estar disponível 99% do tempo (alta disponibilidade).
- **RNF02**: O tempo médio de resposta da API deve ser inferior a 500ms.
- **RNF03**: O sistema deve ser acessível em dispositivos móveis e desktops.
- **RNF04**: Dados sensíveis devem ser protegidos com criptografia.
- **RNF05**: O sistema deve seguir boas práticas de segurança da OWASP.
- **RNF06**: Os uploads devem ser limitados a 100MB por arquivo.
