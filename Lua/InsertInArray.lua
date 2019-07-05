function str2time(hora) 
	return tonumber(string.sub(hora, 1, 2)) * 3600 + tonumber(string.sub(hora, 4, 5)) * 60 + tonumber(string.sub(hora, 7, 8))
end

hora_array = {"20:03:02", "20:03:35"}
horaInicial = str2time(hora_array[1])
horaFinal = str2time(hora_array[2])
hora_array = {}
for i = horaInicial, horaFinal do
	hora = math.floor(i / 3600)
	minuto = math.floor((i - hora * 3600) / 60)
	segundo =  math.floor(i - hora * 3600 - minuto * 60)
    table.insert(hora_array, string.format("%02d:%02d:%02d", hora, minuto, segundo))
end

for i, v in ipairs(hora_array) do print(v) end

--https://pt.stackoverflow.com/q/49812/101
