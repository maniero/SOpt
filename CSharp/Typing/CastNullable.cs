condenacaoInsert.qtd_ano_pena = 
     (!string.IsNullOrEmpty(readerCondenacao["qtd_ano_pena"].ToString())) ? 
     int.Parse(readerCondenacao["qtd_ano_pena"].ToString()) : (int?)null;
     
//https://pt.stackoverflow.com/q/54973/101
