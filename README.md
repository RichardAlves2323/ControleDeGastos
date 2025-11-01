# 💰 Controle de Gastos - Windows Forms

Aplicação desenvolvida em **C# (Windows Forms)** com o objetivo de auxiliar no **gerenciamento financeiro pessoal**, permitindo o **registro, categorização e visualização de transações** de forma simples e intuitiva.

---

## 🧾 Sobre o Projeto

O **Controle de Gastos** é uma aplicação desktop que possibilita o usuário acompanhar suas **receitas** e **despesas** ao longo do tempo.  
O sistema utiliza duas entidades principais:

- **Categoria**  
  - `Nome`: nome da categoria (ex: Alimentação, Salário, Lazer, etc.)  
  - `Tipo`: define se a categoria é uma **Receita** ou **Despesa**

- **Transação**  
  - `Categoria`: categoria vinculada (ex: Salário → Receita, Mercado → Despesa)  
  - `Data`: data em que ocorreu a transação  
  - `Valor`: valor monetário da transação  

As transações são exibidas em uma **tabela interativa** (DataGridView) e apresentadas visualmente em um **gráfico de pizza**, destacando a proporção entre receitas e despesas.

---

## ⚙️ Funcionalidades

- ✅ Cadastro de categorias (com tipo Receita ou Despesa)  
- ✅ Registro de transações vinculadas a categorias  
- ✅ Exibição das transações em tabela com todos os detalhes  
- ✅ Cálculo e exibição automática do **saldo final**  
- ✅ Geração de **gráfico de pizza** representando a distribuição de gastos  
- ✅ Interface simples e intuitiva desenvolvida no Windows Forms  

---


## 📊 Interface do Usuário

A interface foi construída com o **Windows Forms**, e inclui:

- Formulário para **cadastrar categorias e transações**
- **Tabela (DataGridView)** exibindo todas as transações
- **Gráfico de pizza (Chart Control)** ilustrando a relação entre receitas e despesas
- **Labels e campos de totalização** exibindo o saldo final

---



## 🛠️ Tecnologias Utilizadas

- **C#**
- **.NET Framework / .NET 6+**
- **Windows Forms**
- **System.Windows.Forms.DataVisualization.Charting** (para o gráfico)
- **ADO.NET ou List em memória** (dependendo da implementação dos dados)


---

## 📈 Futuras Melhorias

- [x] Persistência em banco de dados (SQLite ou SQL Server)  
- [ ] Filtros por data e categoria  
- [ ] Relatórios financeiros exportáveis (PDF/Excel)  
- [ ] Dashboard mais completo com gráficos dinâmicos  

---


