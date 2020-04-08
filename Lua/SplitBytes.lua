local function sepbytes(num)
	local t = {};
	local byte = 0;
	repeat
    	table.insert(t, 1, bit32.band(bit32.rshift(num, byte), 0xff));
    	byte = byte + 8
	until byte > 24
	return table.unpack(t);
end

print(sepbytes(2000));

--https://pt.stackoverflow.com/q/175476/101
