public static TResult ToEntityForType<TResult>(this DataRow row, Type type) {
    var entity = Activator.CreateInstance<type>() as TResult;
    var properties = entity.GetType().GetProperties().ToList();
    foreach (var item in row.Table.Columns) {
        if (properties.Single(x => String.Compare(x.Name, item.ColumnName, StringComparison.OrdinalIgnoreCase) == 0) != null) {
            prop.SetValue(entity, String.IsNullOrWhiteSpace(Convert.ToString(item)) ? null : item));
    }
    return entity;
}

//https://pt.stackoverflow.com/q/213053/101
