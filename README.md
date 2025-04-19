# 📱 Calculadora Windows Forms

Uma calculadora simples desenvolvida em **C# com Windows Forms**, com suporte a operações matemáticas básicas e funções especiais como raiz quadrada e potência cúbica.

## ✨ Funcionalidades

- Operações básicas: adição (`+`), subtração (`-`), multiplicação (`*`) e divisão (`/`)
- Cálculo de **raiz quadrada** (`√`)
- Cálculo de **potência cúbica** (`^3`)
- Interface gráfica amigável feita com Windows Forms
- Exibição e avaliação dinâmica das expressões

## 🚀 Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/calculadora-winforms.git
   ```

2. Abra o projeto no **Visual Studio**.

3. Compile e execute (`F5`).

## 🧠 Lógica de Cálculo

O botão de resultado (`button7_Click`) percorre o conteúdo do campo de texto (`txtresultado`) e interpreta cada caractere:

- Dígitos e ponto (`.`) são concatenados para formar os números.
- Operadores são armazenados e usados para aplicar as operações com base em um método auxiliar `Calcular`.
- Suporte extra para:
  - `^3` → Aplica `Math.Pow(número, 3)`
  - `√` → Aplica `Math.Sqrt(número)`

## 🛠️ Tecnologias Utilizadas

- C#
- Windows Forms
- .NET Framework

## Integrantes

- RM557074 Guilherme Guimarães
- RM555547 Matheus Oliveira de Luna
- RM554507 Thiago Moreno Matheus
- RM556118 Celso Canaveze Teixeira Pinto
