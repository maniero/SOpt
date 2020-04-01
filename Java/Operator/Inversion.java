button.setOnClickListener(new View.OnClickListener() {
@Override
public void onClick(View v) {
    if(nome.getText().toString().trim().equals("") || teste.getText().toString().trim().equals("") || cpf.getText().toString().trim().equals("")){
        Toast.makeText(getApplicationContext(),"Vazio", Toast.LENGTH_SHORT).show();
    }else{
        Toast.makeText(getApplicationContext(),"Não vazio", Toast.LENGTH_SHORT).show();
    }
}
});

//https://pt.stackoverflow.com/q/172216/101
