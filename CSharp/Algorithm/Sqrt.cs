if (op2 == null) flag = !flag;
else if (operacao != null) {
    op1 = operacao(op1, op2);
    op2 = null;
    flag = true;
}
operacao = (a, b) => (float?)Convert.ToSingle(Math.Sqrt(a));
txt.Text = op1.ToString() + "√";
break;

//https://pt.stackoverflow.com/q/136662/101
