public abstract class GenericConnection {

    private Connection conn;
    private Statement st;

    public Statement getSt() {
        return st;
    }

    public void setSt(Statement st) {
        this.st = st;
    }

    public Connection getConn() {
        return conn;
    }

    public void setConn(Connection conn) {
        this.conn = conn;
    }

    protected Properties dbProperties = new Properties();    

    public Properties getDbProperties() {
        if (dbProperties == null) {
            try {
                dbProperties.load(new FileInputStream("src/properties/conf.properties"));
            } catch (FileNotFoundException ex) {
                Logger.getLogger(GenericConnection.class.getName()).log(Level.SEVERE, null, ex);
            } catch (IOException ex) {
                Logger.getLogger(GenericConnection.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
        return dbProperties;
    }

    public void setDbProperties(Properties dbProperties) {
        GenericConnection.dbProperties = dbProperties;
    }

    public Connection getConnection();
}

public class OracleConnection extends GenericConnection {

    @Override
    public Connection getConnection() {
        if (getConn() != null) {
            return getConn();
        } else {
            try {
                String url = "jdbc:oracle:thin:@" + getDbProperties().getProperty("ServerOracle") + ":" + getDbProperties().getProperty("portOracle") + ":" + getDbProperties().getProperty("sidOracle");
                setConn(DriverManager.getConnection(url, getDbProperties().getProperty("userOracle"), getDbProperties().getProperty("passwdOracle")));
                setSt(getConn().createStatement());
                return getConn();
            } catch (SQLException ex) {
                Logger.getLogger(OracleConnection.class.getName()).log(Level.SEVERE, null, ex);
                return null;
            }
        }
    }
}

//https://pt.stackoverflow.com/q/142868/101
