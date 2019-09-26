#coding: utf-8
__author__ = 'Dener Carvalho'

import sqlite3
import io

#Conecta ao banco
conn = sqlite3.connect('clientes.db')

with io.open('clientes_dump.sql', 'wb') as f:
    for linha in conn.iterdump():
        f.write("%s\n" % linha)

print 'Backup efetuado com sucesso.'
print 'Salvo como clientes_dump.sql'

conn.close()

#https://pt.stackoverflow.com/q/82516/101
