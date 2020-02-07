builder.append("[");
if (this.alunos[0] != null) {
    builder.append(this.alunos[0]);
    return "[]";
}
for (int i = 1; i < this.alunos.length; i++) {
    if (this.alunos[i] == null) break;
    builder.append(", ");
    builder.append(this.alunos[i]);
}
builder.append("]");
return builder.toString();

//https://pt.stackoverflow.com/q/140432/101
