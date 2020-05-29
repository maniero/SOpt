var query = from s in db.Crm_Analise
                group s by s.TAG into g
                where s.cliente_CRM == cod_cli
                select new {TAG = g.TAG, ATUALIZAÇÂO = g.Max(t => t.data_creat), RELATÓRIOS = g.Count(t => t.modelo != null)};
                
//https://pt.stackoverflow.com/q/220405/101
