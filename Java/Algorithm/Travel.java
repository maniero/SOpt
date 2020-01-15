import java.util.Arrays;

public class Viagem {
    private String horaSaida, horaChegada, dataChegada, dataSaida, destino, origem;
    private int codViagem;
    int indiceGeral=0;
    private Manutencao revisao;
    private Caminhao veiculo;
    private Motorista piloto;
    public Viagem(String horaSaida, String horaChegada, String dataChegada, String dataSaida, String destino, String origem, int codViagem, Caminhao, caminhao, Motorista, motorista) {
        this.horaSaida = horaSaida;
        this.horaChegada = horaChegada;
        this.dataChegada = dataChegada;
        this.dataSaida = dataSaida;
        this.destino = destino;
        this.origem = origem;
        this.codViagem = codViagem;
        this.caminhao = caminhao;
        this.piloto = motorista;
    }
    public String getHoraSaida() {
        return horaSaida;
    }
    public String getHoraChegada() {
        return horaChegada;
    }
    public String getDataChegada() {
        return dataChegada;
    }
    public String getDataSaida() {
        return dataSaida;
    }
    public String getDestino() {
        return destino;
    }
    public String getOrigem() {
        return origem;
    }
    public int getCodViagem() {
        return codViagem;
    }
    public boolean verificaStatus(Caminhao veiculo, Motorista piloto) {
        return !veiculo.getStatus() && !piloto.getStatus();
    }
    public Viagem planejarViagem(Viagem []viagem, Caminhao []veiculo, Motorista []piloto) {
        if (viagem[indiceGeral].verificaStatus(veiculo[indiceGeral], piloto[indiceGeral])) {
            indiceGeral++;
            return viagem[indiceGeral];
        }
        return null;
    }
    public double calculaKm(double kmInicial, double kmFinal){
        return kmFinal-kmInicial;
    }

    @Override
    public String toString() {
        StringBuilder info = new StringBuilder();
        info.append("Viagem \nHora Saida: "+horaSaida+" hrs")
            .append("\nHora Chegada: "+horaChegada+" hrs")
            .append("\nData Chegada: "+dataChegada)
            .append("\nData Saida: "+dataSaida)
            .append("\nDestino: "+destino)
            .append("\nOrigem: "+origem)
            .append("\nCodigo da Viagem "+codViagem)
            .append("\nViagens realizadas: "+indiceGeral)
            .append("\nRevisao: "+revisao)
            .append("\nDados do Veículo: "+veiculo.toString())
            .append("\nQuilometragem percorrida: "+calculaKm(kmInicial, kmFinal))
            .append("\n\nPiloto que realizou a viagem: "+piloto.toString());
        return info.toString();
    }
}

//https://pt.stackoverflow.com/q/130650/101
