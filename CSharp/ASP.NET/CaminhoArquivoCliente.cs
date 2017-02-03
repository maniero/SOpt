protected void btnUpload_Click(object sender, EventArgs e) {
    string fileName = System.IO.Path.GetFileName(FileUpload1.PostedFile.FileName);
    FileUpload1.PostedFile.SaveAs(Server.MapPath("/Uploads/" + fileName));
}

//http://pt.stackoverflow.com/q/15721/101
