using System;

public static class Program {
    public static void Main() => new DAL.DadosConexao(true, null);
}

namespace DAL {
    public class DadosConexao {
        private string servidor;
        private bool isServ;       

        public DadosConexao(bool isServ, string servidor) {
            this.isServ = isServ;
            this.servidor = servidor;
        }

        public string StringConexao {
            get {
                if (!isServ) servidor = Environment.MachineName.ToString();
                return "Data Source=" + servidor + 
                       "\\MINHAINSTANCIA;" + 
                       "Initial Catalog=MINHABASE;" + 
                       "Persist Security Info=True;" + 
                       "User ID=sa;" + 
                       "Password=123456";
            }
        }
    }
}

//https://pt.stackoverflow.com/q/93033/101
