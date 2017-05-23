    public class GenericaBLO<T> : IGenericaBLO<T> where T : class {
        private IGenericaDAO<T> dao;
    
        public GenericaBLO() {}
        public GenericaBLO(IGenericaDAO<T> dao) { //se usar C#7 pode fazer igual aos métodos abaixo
            this.dao = dao;
        }
    
        public bool Add(T e) => dao.Add(e);
        public bool Update(T e) => dao.Update(e);
        public bool Delete(T e) => dao.Delete(e);
        public List<T> GetAll() => dao.GetAll();
        public T Get(int id) => dao.Get(id);
    }

    public class GenericaDAO<T> : IGenericaDAO<T> where T : class {
        internal ApplicationDbContext Context  { get; set; }
        protected DbSet<T> DbSet { get; set; }
    
        public GenericaDAO() {
            Context = new ApplicationDbContext();
            DbSet = Context.Set<T>();
        }
    
        public bool Add(T e) {
            Context.Entry(e).State = EntityState.Added;
            Context.SaveChanges();
            return true;
        }
    
        public bool Update(T e) {
            Context.Entry(e).State = EntityState.Modified;
            Context.SaveChanges();
            return true;
        }
    
        public bool Delete(T e) {
            Context.Entry(e).State = EntityState.Deleted;
            Context.SaveChanges();
            return true;
        }
    
        public List<T> GetAll() => DbSet.ToList();
    
        public T Get(int id) => DbSet.Find(id);
    }

//Alternative

    public bool Add(T e) {
        try {
            Context.Entry(e).State = EntityState.Added;
            Context.SaveChanges();
            return true;
        } catch (ExceptionMaisEspecica ex) { //isto é importante, não capture Exception
            return false;
        }
    }
    
    //https://pt.stackoverflow.com/q/206803/101
