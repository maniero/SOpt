public interface IRepository<T> where T: IEntity {
    IEnumerable<T> List { get; }
    void Add(T entity);
    void Delete(T entity);
    void Update(T entity);
    T FindById(int Id);
}

//https://pt.stackoverflow.com/q/101692/101
