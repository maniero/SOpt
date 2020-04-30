ATTACH 'path/aqui/vihicles1.sqlite' as v1;         
ATTACH 'path/aqui/vihicles2.sqlite' as v2;
ATTACH 'path/aqui/vihicles3.sqlite' as v3;
ATTACH 'path/aqui/vihicles4.sqlite' as v4;

INSERT INTO tblVehicle SELECT * FROM v1.tblVehicle;
INSERT INTO tblVehicle SELECT * FROM v2.tblVehicle;
INSERT INTO tblVehicle SELECT * FROM v3.tblVehicle;
INSERT INTO tblVehicle SELECT * FROM v4.tblVehicle;

DETACH 'path/aqui/vihicles1.sqlite';
DETACH 'path/aqui/vihicles2.sqlite';
DETACH 'path/aqui/vihicles3.sqlite';
DETACH 'path/aqui/vihicles4.sqlite';

--https://pt.stackoverflow.com/q/185423/101
