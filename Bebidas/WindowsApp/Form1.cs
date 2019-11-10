﻿
using Dados.DAO;
using Dados.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        ArquivoTexto dados = new ArquivoTexto();
        public Form1()
        {
            InitializeComponent();
            ListarPessoas();
        }
        private void ListarPessoas()
        {
            List<Pessoa> lista = dados.LerTodos();
            dgvPessoas.DataSource = lista;
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            lblErro.Text = "";
            string nome = txtNome.Text;
            string sobrenome = txtSobrenome.Text;
            string cpf = txtCpf.Text;

            if (ValidaFormulario(nome, sobrenome))
            {
                Pessoa pessoa = new Pessoa();
                pessoa.Nome = nome;
                pessoa.Sobrenome = sobrenome;
                pessoa.CPF = cpf;
                
                dados.Salvar(pessoa);

                Limpar();
                ListarPessoas();


            }



        }
        private bool ValidaFormulario(string nome,string sobrenome)
        { 
            bool valido = true;
            if (nome.Trim() == "")
            {
                valido = false;
                lblErro.Text = " O nome não foi preenchido ";
            }
            if (sobrenome.Trim() == "")
            {
                valido = false;
                lblErro.Text += " O Sobrenome não foi preenchido ";
            }
            return valido;
          }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtCpf.Text = "";
        }
    }
    
}
