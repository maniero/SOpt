using System;
					
public static class Program {
	public static void Main() {
		DAL.DadosConexao.isServ = true;
		var con = DAL.DadosConexao.StringConexao;
	}
}

namespace DAL {
    public static class DadosConexao {
		public static string servidor { get; set; }
        public static bool isServ { get; set; }

        public static string StringConexao {
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
