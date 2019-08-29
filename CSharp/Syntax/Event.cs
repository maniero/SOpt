private ChangedEventHandler ChangedField;
public void AddChangedHandler(ChangedEventHandler handler) => this.ChangedField = (ChangedEventHandler)Delegate.Combine(this.Changed, handler);
public void RemoveChangedHandler(ChangedEventHandler handler) => this.ChangedField = (ChangedEventHandler)Delegate.Remove(this.Changed, handler);

//https://pt.stackoverflow.com/q/56957/101
