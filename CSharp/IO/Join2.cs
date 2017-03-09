using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

public class MergeFiles {
    public static void Main(string[] args) {
        var caminhoOrigem = @"C:\teste";
        var nomeArquivoCompleto = @"C:\teste\saida.txt";
        var itens = new Dictionary<string, int>(); //Cria a estrutura que permite chaves únicas do tipo string e valores associados do tipo int
        int resultado;
        foreach (var arquivo in Directory.GetFiles(caminhoOrigem, "*.txt")) { //Pega todos os arquivos com extensão txt disponíveis no diretório
            if (arquivo != nomeArquivoCompleto) { //Não deixa processar o próprio arquivo que está sendo criado
                foreach (var linha in File.ReadAllLines(arquivo)) { //Lê todas as linhas individualmente de cada arquivo
                    if (linha.Length == 9) { //Garante que a linha tem 9 caracteres
                        var chave = linha.Substring(0, 6); //Pega os 6 primeiros caracteres
                        var valor = (int.TryParse(linha.Substring(6, 3), out resultado) ? resultado : 0); //Pega os 3 caracteres seguintes e converte para numérico
                        if (itens.ContainsKey(chave)) { //verifica se já existe a chave no dicionário
                            itens[chave] = itens[chave] + valor; //adiciona o valor obtido na linha à chave já existe no dicionário
                        } else {
                            itens.Add(chave, valor); //Adiciona uma nova chave ainda inexistente no dicionário
                        }
                    }
                }
            }
        }
        //Cria o arquivo destino adicionando todas as linhas do dicionário recriando a mesma estrutura anterior através do LINQ
        File.WriteAllLines(nomeArquivoCompleto, itens.Select(item => item.Key + item.Value.ToString("000")).ToArray());
    }
}

//http://pt.stackoverflow.com/q/16719/101
