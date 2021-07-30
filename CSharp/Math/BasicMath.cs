var deslocamento = lote.AlvoPasso / ushort.MaxValue;
dadosBalanca[3] = deslocamento;
dadosBalanca[4] = lote.AlvoPasso - ushort.MaxValue * deslocamento;

//https://pt.stackoverflow.com/q/277279/101
