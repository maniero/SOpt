public ActionResult Index(ViewModel model, string returnUrl) {
    var query = "UPDATE Table SET Status = 'C' WHERE Id = @Num";
    using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
    using (var command = new SqlCommand(query, connection)) {
        command.Parameters.Add("@Num", SqlDbType.Int).Value = model.Numero;
        connection.Open();
        command.ExecuteNonQuery();
    }
    return RedirectToAction("Page", "Account");
}

//https://pt.stackoverflow.com/q/202903/101
