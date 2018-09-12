public const string DeletadoSim = "S";
public const string DeletadoNao = "N";
public const string AtivaSim = "S";
public const string AtivaNao = "N";
public const string CertificadoDisponivel = "S";
public const string CertificadoNaoDisponivel = "N";
public const string CertificadoEmAnalise = "A";

//

public enum Deletado { [Display("N")]Nao, [Display("S")]Sim }
public enum Certificado { [Display("N")]NaoDisponivel, [Display("S")]Disponivel, [Display("A")]EmAnalise }

//Usando:

public Deletado Deletado { get; set; } = Deletado.Nao;

//https://pt.stackoverflow.com/q/313042/101
