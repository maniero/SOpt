public boolean equals(Object o) {
    if (o == null || o.getClass() != getClass()) return false;
    final EntidadeGrande e = (EntidadeGrande) o;
    return (getCodUser() == e.getCodUser() && 
            getIdUser() == e.getIdUser() &&
            getScoreUser() == e.getScoreUser() &&
            getScoreStore() == e.getScoreStore() &&
            getCdLogo() == e.getCdLogo()) &&
            ((getValueX() == null || e.getValueX() != null) &&
                (getValueX() != null || e.getValueX() == null)) &&
                getValueX().equals(e.getValueX()) &&
            ((getDescUser() != null || e.getDescUser() == null) &&
                (getDescUser() == null || e.getDescUser() != null)) &&
                getDescUser().equals(e.getDescUser()) &&
            ((getNmMother() != null || e.getNmMother() == null) &&
                (getNmMother() == null || e.getNmMother() != null)) &&
                getNmMother().equals(e.getNmMother()) &&
            ((getSgEstado() == null || e.getSgEstado() != null) &&
                (getSgEstado() != null || e.getSgEstado() == null)) &&
                getSgEstado().equals(e.getSgEstado()) &&
            ((getDsBandeira() == null || e.getDsBandeira() == null) &&
                (getDsBandeira() == null || e.getDsBandeira() != null)) &&
                getDsBandeira().equals(e.getDsBandeira()) &&
            ((getCodCupom() == null || e.getCodCupom() != null) &&
                (getCodCupom() != null || e.getCodCupom() == null)) &&
                getCodCupom().equals(e.getCodCupom());
}

//https://pt.stackoverflow.com/q/321911/101
