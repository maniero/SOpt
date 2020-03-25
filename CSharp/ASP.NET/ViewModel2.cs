public class Program {
	public static void Main() {
		var vmc = new ApoQueueVMConstrutor(); //construiu sem inicializar nada, mesmo sem ter sido declarado, o construtor está lá
		var vm1 = new ApoQueueVM("xxx", "yyy"); //construiu conforme o esperado
//		var vm2 = new ApoQueueVM(); //não existe construtor com esta assinatura
	}
}

public class ApoQueueVM {
    public ApoQueueVM(string apoQueue, string apoFileBL) {
        this.EnableExport = true;
        this.KeyFigure = apoQueue;
        this.PathFileGenerated = apoFileBL;
    }

    public string KeyFigure { get; set; }
    public bool HaveInconsistencies { get; set; }
    public string PathFileGenerated { get; set; }
    public bool EnableExport { get; set; }
}

public class ApoQueueVMConstrutor {
    public string KeyFigure { get; set; }
    public bool HaveInconsistencies { get; set; }
    public string PathFileGenerated { get; set; }
    public bool EnableExport { get; set; }
}
