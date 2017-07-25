using System.Collections.Generic;
					
public interface IObjetosBase {
     IList<IObjetosBase> Get();
}

public class ObjetosBase : IObjetosBase {
    public virtual IList<IObjetosBase> Get() { return new List<IObjetosBase>(); }
}

public class Aluno : ObjetosBase {
	public override IList<IObjetosBase> Get() { return new List<IObjetosBase>() { new Aluno() }; }
}

//https://pt.stackoverflow.com/q/223364/101
