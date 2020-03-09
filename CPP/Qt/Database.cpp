#ifndef DBCONNECTION_H
#define DBCONNECTION_H

#include <QObject>
#include <QSqlDatabase>
#include <QSqlError>

enum TypeDBConnection{
 QDB2,
 QIBASE,
 QMYSQL,
 QOCI,
 QODBC,
 QPSQL,
 QSQLITE,
 QSQLITE2,
 QTDS
};

class DBConnection
{
protected:
  QSqlDatabase db;
  QString dbname;
  TypeDBConnection type;
public:
  QString getDBName();
  TypeDBConnection getTypeConnection();
  DBConnection *setDBName(QString value);
  DBConnection *setTypeConnetion(TypeDBConnection value);
  bool open();
  void close();
};
#endif // DBCONNECTION_H
DBConnection Class
#include "dbconnection.h"

QString DBConnection::getDBName()
{
    return this->dbname;
}
TypeDBConnection DBConnection::getTypeConnection()
{
    return this->type;
}
DBConnection *DBConnection::setDBName(QString value)
{
    this->dbname = value;
    return this;
}
DBConnection *DBConnection::setTypeConnetion(TypeDBConnection value)
{
    this->type = value;
    return this;
}
bool DBConnection::open()
{
    switch (this->type) {
    case QDB2:
        this->db = QSqlDatabase::addDatabase("QDB2");
        break;
    case QIBASE:
        this->db = QSqlDatabase::addDatabase("QIBASE");
        break;
    case QMYSQL:
        this->db = QSqlDatabase::addDatabase("QMYSQL");
        break;
    case QOCI:
        this->db = QSqlDatabase::addDatabase("QOCI");
        break;
    case QODBC:
        this->db = QSqlDatabase::addDatabase("QODBC");
        break;
    case QPSQL:
        this->db = QSqlDatabase::addDatabase("QPSQL");
        break;
    case QSQLITE:
        this->db = QSqlDatabase::addDatabase("QSQLITE");
        break;
    case QSQLITE2:
        this->db = QSqlDatabase::addDatabase("QSQLITE2");
        break;
    case QTDS:
        this->db = QSqlDatabase::addDatabase("QTDS");
        break;
    default:
        this->db = QSqlDatabase::addDatabase("QSQLITE");
        break;
    }

    this->db.setDatabaseName(this->dbname);
    //não é necessário validar o caminho do BD em android, pois o mesmo o cria!
    //if (QFile::exists(this->dbname))
    try
    {
        return db.open();
    }catch(...)
    {
        qDebug() << db.lastError().text();
    }
    return false;
}
void DBConnection::close()
{
    db.close();
}
Utilizando a classe
#include <QGuiApplication>
#include <QDebug>
#include "dbconnection.h"

int main(int argc, char *argv[])
{    
    QGuiApplication app(argc, argv);

    QQmlApplicationEngine engine(QUrl("qrc:/main.qml"));

    DBConnection db* = new DBConnection();

    qDebug() << "Comunicou com bd: " << db->setDBName("Data.db")->setTypeConnetion(QSQLITE)->open();

    delete(db);

    return app.exec();
}

//https://pt.stackoverflow.com/q/153839/101
