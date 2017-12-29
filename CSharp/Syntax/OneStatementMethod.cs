public ICommand ChangePositionCommand {
    return new Command((obj) => {
        _positionIndex++;
        if (_positionIndex >= Positions.Count)
            _positionIndex = 0;
        Position = Positions[_positionIndex];
        RaisePropertyChanged(nameof(Position));
    });
}

//https://pt.stackoverflow.com/q/265696/101
