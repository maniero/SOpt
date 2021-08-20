void resetStage() {
    _fullLife = _halfLife = _almostDead = false;
}

void boolReset(bool resetTo, ref bool b1, ref bool b2, ref bool b3) {
    b1 = b2 = b3 = resetTo;
}

void resetStage() {
    boolReset(false, ref _fullLife, ref _halfLife, ref _almostDead);
}
void resetStage() {
    _fullLife = _halfLife = _almostDead = false;
}

//https://pt.stackoverflow.com/q/363350/101
