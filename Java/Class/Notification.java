private List<Observer> observers = new ArrayList<Observer>();

public void subscribe(Observer observer) {
    observers.add(observer);       
}

public void notifyAllObservers() {
    for (Observer observer : observers) {
        observer.update(this);
    }
}

public void setNome(String nome) {
    this.nome = nome;
    notifyAllObservers();
}

public interface ObserverPessoa {
    public void update(Pessoa pessoa);
}

public class Consumidor extends Observer {
    @Override
    public void update(Pessoa pessoa) {
        //faz o que quiser aqui 
    }
}

//https://pt.stackoverflow.com/q/160295/101
