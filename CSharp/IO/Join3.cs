using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

public class MergeFiles {
    public static void Main(string[] args) {
        var itens = new Dictionary<string, Dictionary<string, int>>(); //Cria a estrutura que permite chaves únicas do tipo string e valores associados do tipo int
        int resultado;
        foreach (var arquivo in Directory.GetFiles(@"C:\teste", "*.txt")) { //Pega todos os arquivos com extensão txt disponíveis no diretório
            var chaveArquivo = "";
            foreach (var linha in File.ReadAllLines(arquivo)){ //Lê todas as linhas individualmente de cada arquivo
                if (linha.Substring(6, 1)  == ";") { //Verifica se esta é a primeira linha
                   chaveArquivo = linha.Substring(0, 6) + linha.Substring(7, 8); //Pega os 6 primeiros caracteres e os 8 sequintes pulando o ;
                    if (!itens.ContainsKey(chaveArquivo)) { //verifica se não existe a chave com nome do arquivo
                        itens.Add(chaveArquivo, new Dictionary<string, int>()); //Adiciona uma nova chave ainda inexistente no dicionário
                    }
                } else {
                    var chave = linha.Substring(0, 6); //Pega os 6 primeiros caracteres
                    var valor = (int.TryParse(linha.Substring(6, 3), out resultado) ? resultado : 0); //Pega os 3 caracteres seguintes e converte para numérico
                    if (itens[chaveArquivo].ContainsKey(chave)) { //verifica se já existe a chave no dicionário
                        itens[chaveArquivo][chave] = itens[chaveArquivo][chave] + valor; //adiciona o valor obtido na linha à chave já existe no dicionário
                    } else {
                        itens[chaveArquivo].Add(chave, valor); //Adiciona uma nova chave ainda inexistente no dicionário
                    }
                }
            }
        }
        //Cria os arquivos agrupados adicionando todas as linhas do dicionário recriando a mesma estrutura anterior através do LINQ
        foreach(var arquivo in itens) {
            File.WriteAllLines(arquivo.Key + ".txt", arquivo.Value.Select(item => item.Key + item.Value.ToString("000")).ToArray());
        }
    }
}

//http://pt.stackoverflow.com/q/16818/101
