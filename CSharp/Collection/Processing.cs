namespace AvalicaoPratica.View {
    public partial class Home : System.Web.UI.Page {
        List<_Problema1> lstTotal = new List<_Problema1>();
        protected void Page_Load(object sender, EventArgs e) {
            _Problema1 prob1 = new _Problema1();
            while (prob1.Cont <= 64) {
                prob1.Vtotal += prob1.Graos;
                prob1.Graos *= 2;
                prob1.Cont++;
            }
            lstTotal.Add(prob1); //<== a mudança mais importante aqui
            GridView1.DataSource = lstTotal;
            GridView1.DataBind();
        }
    }
}

//https://pt.stackoverflow.com/q/39080/101
