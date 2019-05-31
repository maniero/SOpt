public abstract class ServiceData { /*...*/ }
public class EchoData extends ServiceData { /*...*/ }
public abstract class Service<T extends ServiceData> {
      protected abstract ServiceResponse onExecute(T data) throws Exception;
}
public class EchoService extends Service<EchoData> {
    @Override
    protected ServiceResponse onExecute(EchoData data) throws Exception {
        return null;
    }
}

//https://pt.stackoverflow.com/q/385287/101
