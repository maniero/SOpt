def dbConnect(): return InfluxDBClient(INFLUXDB_HOST, INFLUXDB_PORT, INFLUXDB_USERNAME, INFLUXDB_PASSWORD = 'root', INFLUXDB_DATABASE)

#https://pt.stackoverflow.com/q/360447/101
