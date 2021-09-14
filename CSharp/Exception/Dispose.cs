public void Show() {
    using (var frm = new Form()) {
        frm.ShowDialog();
    }
}

public void Show() {
    using var frm = new Form());
    frm.ShowDialog();
}

//https://pt.stackoverflow.com/q/22284/101
