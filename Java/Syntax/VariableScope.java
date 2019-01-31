public class TracoActivity extends Activity {
    private int mc;
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_traco);
        mc = 15;
    } //fecha onCreate

    public void ver_log(View v){
        DialogLog(); 
    }

    private void DialogLog(){
        final Dialog dialogLog = new Dialog(this);
        dialogLog.requestWindowFeature(Window.FEATURE_NO_TITLE);
        dialogLog.setContentView(R.layout.dialog_log);
        TextView relatorio = (TextView) dialogLog.findViewById(R.id.relatorio);
        final Button btnFechar = (Button) dialogLog.findViewById(R.id.btn_fechar);
        relatorio.setText("MC = " + mc);
        btnFechar.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                dialogLog.dismiss();
            }
        });
        dialogLog.show();
    }
} //fecha class TracoActivity

//https://pt.stackoverflow.com/q/45132/101
