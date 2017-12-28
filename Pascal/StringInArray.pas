function StringInArray(const Value: string; Strings: array of string): Boolean;
var I: Integer;
begin
    Result := True;
    for I := Low(Strings) to High(Strings) do
        if Strings[i] = Value then Exit;
    Result := False;
end;

//https://pt.stackoverflow.com/q/37339/101
