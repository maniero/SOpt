if (!datetime.TryParse(reader["Data"], out var data)) data = DateTime.MinValue;
Data = data;

//https://pt.stackoverflow.com/q/430052/101
