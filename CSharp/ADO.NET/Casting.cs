using System;  
using System.Collections.Generic;  
using System.ComponentModel;  
using System.Data;  
using System.Drawing;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
using System.Windows.Forms;  
using System.Data.SqlClient;  

namespace PesadaoFinal
{
    public partial class frmLogin : Form
    {

        SqlConnection conn = null;
        private string conexao = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Breno\Documents\Visual Studio 2013\Projects\PesadaoFinal\PesadaoFinal\bd\pesadao_db.mdf;Integrated Security=True;Connect Timeout=30";
        private string consulta = string.Empty;

        public frmLogin()
        {
            InitializeComponent();
        }
        public void logar(){


            conn= new SqlConnection(conexao);

            try{
                string usuario, senha, cargo;

                usuario = txtUsu.Text;
                senha=txtSenha.Text;
                SqlDataReader verCargo = null;
                String usulogado, cpf; 



                if(usuario==string.Empty && senha==string.Empty){

                    MessageBox.Show("Usuário e senha devem ser digitados!");
                }
                else if (usuario != null && senha != null)
                {
                    consulta = @"SELECT * FROM funcionarios WHERE login = @usuario AND senha = @senha";
                    SqlCommand novoLogin = new SqlCommand(consulta, conn);
                    novoLogin.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                    novoLogin.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;

                    conn.Open();


                    object rs = novoLogin.ExecuteScalar();

                    if (rs == null)
                    {
                        MessageBox.Show("Usuário ou Senha Incorretos");
                    }
                    else
                    {
                        verCargo = novoLogin.ExecuteReader(CommandBehavior.CloseConnection);
                        if (verCargo != null)
                        {
                            while (verCargo.Read())
                            {
                                usulogado = (verCargo[2].ToString());
                                cpf = (verCargo[1].ToString());


                            }


                        }
                    }

                }     


            }catch(SqlException erroBD){
                MessageBox.Show(erroBD +"Erro no banco");

            }


        }
        private void frmLogin_Load(object sender, EventArgs e)
        {


        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            logar();
        }
    }
} 

//https://pt.stackoverflow.com/q/44886/101
