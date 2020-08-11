public class SexoController : ControllerBase {
    private readonly DB_SDO_DEVContext contexto;
    [HttpGet]
    public ActionResult<List<Sexo>> GetAll() {
        var optionsBuilder = new DbContextOptionsBuilder<DB_SDO_DEVContext>();
        contexto = new DB_SDO_DEVContext(optionsBuilder.Options)
        return contexto.Sexo.ToList();
    }
}

//https://pt.stackoverflow.com/q/337422/101
