  protected void btnSave_Click(object sender, EventArgs e) {
      var aDay = new List<ProdutoAmortizacaoCreditoDias>();
      var ee = new ProdutoAmortizacaoCreditoDias();
      int dia;
      if (int.TryParse(this.txtDay.Text, out dia)) {
          ee.Dia = ee.Dia = dia;
      } else {
          //faz alguma coisa aqui porque deu erro na conversão.
      }
      if (ProcessingType != 1) {
          ee.FromProductID = this.hdnSourceID.Value;
          ee.ToProductID = this.hdnDestinationID.Value;
      }

//http://pt.stackoverflow.com/q/183397/101
