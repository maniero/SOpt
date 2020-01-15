function Join(const Texts : array of string; const Separator : string) : string;
var
    i : Integer;
begin
    Result := Texts[low(Texts)];
    for i := low(Texts) + 1 to high(Texts) do
        Result := Separator + Result + Texts[i];
end;

//https://pt.stackoverflow.com/q/130875/101
