# 👽 Gerenciador de OVNIs

Este é um aplicativo de gerenciamento de OVNIs desenvolvido em **C# com Windows Forms**. O programa simula o controle de uma nave alienígena, permitindo configurar informações básicas e interagir com o funcionamento da nave e sua tripulação.

## 🚀 Funcionalidades

### Tela Inicial
Ao iniciar o programa, o usuário poderá definir:

- **Quantidade máxima de tripulantes** da nave.
- **Quantidade máxima de pessoas a serem abduzidas**.
- **Planeta de origem** da nave.

Esses parâmetros definem o estado inicial do OVNI e habilitam a próxima etapa do gerenciamento.

### Tela de Gerenciamento
Após configurar os parâmetros iniciais, uma nova janela (Form) será aberta com as seguintes funcionalidades:

- ✅ **Ligar e desligar a nave**.
- 👨‍🚀 **Adicionar ou excluir tripulantes** (respeitando o limite definido).
- 👥 **Abduzir ou desabduzir pessoas**.
- 🌍 **Alterar o planeta de origem**.
- 📋 **Visualização em tempo real** das informações da nave por meio de **labels dinâmicos**, incluindo:
  - Status da nave (Ligada/Desligada)
  - Quantidade de tripulantes atuais
  - Pessoas abduzidas
  - Planeta atual

## 🛠️ Tecnologias Utilizadas

- Linguagem: **C#**
- Framework: **.NET Framework / Windows Forms (WinForms)**
- IDE recomendada: **Visual Studio**
